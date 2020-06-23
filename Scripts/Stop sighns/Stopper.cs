using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    public GameObject messageText;


    void start()
    {
        messageText.SetActive(false); 


    }
    private void OnTriggerEnter(Collider other)
    {
        if((messageText.name == "GameOver - SeaMessage"))
        {
            print("gameOverSea()");
            StartCoroutine(gameOverSea());
        }
        else
        StartCoroutine(startTextAnimation());
       
    }

    private IEnumerator gameOverSea()
    {
        print("gameOverSea()");
        messageText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        messageText.SetActive(false);
        SceneManager.LoadScene("GameOverScene");
    }
   
    public IEnumerator startTextAnimation()
    {
        print("STARTING TEXT");
        messageText.SetActive(true);
        
        yield return new WaitForSeconds(3f);
        messageText.SetActive(false);
        
    }
    
    
}
