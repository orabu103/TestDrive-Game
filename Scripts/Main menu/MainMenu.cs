using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene("LevelScreen");
    }

    public void quitGame()
    {
        Debug.Log("Quit game"); 
        Application.Quit();
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
