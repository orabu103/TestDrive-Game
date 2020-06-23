using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleActivator : MonoBehaviour
{
    public GameObject MidelleTrigger;

    private void OnTriggerEnter(Collider other)
    {
       
        MidelleTrigger.SetActive(true);
    }
}
