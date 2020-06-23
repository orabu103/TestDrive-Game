using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int nextSceneIndex; 
    public void loadNextScene(string sceneName)
    {
        if(sceneName == "gameOver-sea")
        {
            SceneManager.LoadScene(1); 
        }
    }
}
