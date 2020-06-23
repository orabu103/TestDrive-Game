using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianExitTrigger : MonoBehaviour
{
    public GameObject EnterTrigger;
    public GameObject MidelleTrigger;
    public GameObject ExitTrigger;
    public GameObject winTrigger;
    public GameObject goodJobText;
    public GameObject WaitText;

    private void OnTriggerEnter(Collider other)
    {
        WaitText.GetComponent<Animator>().Play("Idele");
        goodJobText.GetComponent<Animator>().Play("FadeIn");
        winTrigger.SetActive(true);
        MidelleTrigger.SetActive(false);
    }

    
}
