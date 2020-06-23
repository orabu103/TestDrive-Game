using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerateTrigger : MonoBehaviour
{
    public GameObject TurnRightText;
    public GameObject carAcceleration;

    private void OnTriggerEnter(Collider other)
    {
        TurnRightText.SetActive(false);
        carAcceleration.SetActive(true);
    }
}
