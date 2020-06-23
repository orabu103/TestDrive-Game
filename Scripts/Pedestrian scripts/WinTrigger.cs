using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public GameObject winTrigger;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Sport Coupe Collider Base")
        {
            SceneManager.LoadScene("LevelSucceed");
        }
    }

}
