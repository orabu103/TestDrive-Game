using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter1 : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        print("Scoring.scoreAmount += 10");
    }
   
}
