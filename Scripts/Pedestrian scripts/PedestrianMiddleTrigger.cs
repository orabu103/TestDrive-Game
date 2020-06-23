using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PedestrianMiddleTrigger : MonoBehaviour
{
    public GameObject MidelleTrigger;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if(other.name == "Sport Coupe Collider Base")
        {
            SceneManager.LoadScene("Level fail");
        }
    }
}
