using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    [SerializeField]
    string SuccessScreen; 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SuccessScreen);
    }

    public void clickToNextLevel()
    {
        SceneManager.LoadScene(SuccessScreen);

    }
}
