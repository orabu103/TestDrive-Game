using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnLeftTrigger : MonoBehaviour
{
    public GameObject slowDownText;
    public GameObject TurnLeftText;

    private void OnTriggerEnter(Collider other)
    {
        slowDownText.SetActive(false);
        TurnLeftText.SetActive(true);
    }
}
