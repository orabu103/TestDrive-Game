using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnRightTrigger : MonoBehaviour
{
    public GameObject TurnLeftText;
    public GameObject TurnRightText;

    private void OnTriggerEnter(Collider other)
    {
        TurnLeftText.SetActive(false);
        TurnRightText.SetActive(true);
    }
}
