using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animate : MonoBehaviour{


private Animator ani;

void Start()
{
    //Pak het animator component en sla die op in de variabele
    ani = GetComponent<Animator>();
}
void Update()
{
    //Check voor verticale input
    if (Input.GetAxis("Vertical") > 0)
    {
            Debug.Log("Boven");
        //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
        //Roep de juiste trigger aan!
        ani.SetTrigger("Walking");
        //SetTrigger is trigger activeren
        ani.ResetTrigger("Catwalk Idle");
        ani.ResetTrigger("Walking R");
        //ResetTrigger is Trigger de-activeren
    }
    else if (Input.GetAxis("Vertical") < 0)
    {
            Debug.Log("Beneden");
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Walking R");
        ani.ResetTrigger("Catwalk Idle");
        ani.ResetTrigger("Walking");
    }
    else
    {
            
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Catwalk Idle");
        ani.ResetTrigger("Walking");
        ani.ResetTrigger("Walking R");
    }
}

}
