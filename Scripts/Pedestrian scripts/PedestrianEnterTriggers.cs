using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianEnterTriggers : MonoBehaviour
{

    public GameObject EnterTrigger;
    public GameObject MidelleTrigger;
    public GameObject winTrigger;
    public GameObject WaitText;
    public GameObject goodJobText;


    private void OnTriggerEnter(Collider other)
    {
        goodJobText.GetComponent<Animator>().Play("Idele");
        WaitText.GetComponent<Animator>().Play("FadeIn"); 
        winTrigger.SetActive(false);
        MidelleTrigger.SetActive(false);
    }

}
