using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Events;


public class HUD : MonoBehaviour
{

     [SerializeField] private TMP_Text _temps;

    private bool _decompeActif = false;

    public UnityEvent _auChangementDuTemps;

    public UnityEvent _aLaFinDuTemps;

    public float Temps = 0;



    // Start is called before the first frame update
    void Start()
    {
        Afficher();


        DemarrerDecompte();
    }

    // Update is called once per frame
    void Update()
    {
        if (_decompeActif == true)
        {
            if (Temps >= 0)
            {
                Temps += Time.deltaTime;

                _auChangementDuTemps.Invoke();


            }
            else
            {
                Temps = 0;

                _decompeActif = false;

                _aLaFinDuTemps.Invoke();


            }
        }
    }


     public void Afficher()
    {
        Debug.Log("oui");

        float temps = 0;

        if (temps < 0)
        {
            temps = 0;
        }




        TimeSpan ts = TimeSpan.FromSeconds(temps);

        //00:00:00:000
        _temps.text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
    }

    public void DemarrerDecompte()
    {

        

        _decompeActif = true;


    }
}
