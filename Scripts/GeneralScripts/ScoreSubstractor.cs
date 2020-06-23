using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreSubstractor : MonoBehaviour
{
    public GameObject enterTrigger;
    private IEnumerator OnTriggerExit(Collider other)
    {
        Scoring.scoreAmount -= 10;
        enterTrigger.SetActive(false);
        yield return new WaitForSecondsRealtime(5);
        enterTrigger.SetActive(true);



    }
}
