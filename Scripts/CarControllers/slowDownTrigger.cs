using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownTrigger : MonoBehaviour
{
    public GameObject slowDownText;
    public GameObject accelerationText;

    private void OnTriggerEnter(Collider other)
    {
        accelerationText.SetActive(false);
        slowDownText.SetActive(true);
    }

}
