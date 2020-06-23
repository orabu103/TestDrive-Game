using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccesButtonChooser : MonoBehaviour
{
    public void GoToNextLevel()
    {
        SceneManager.LoadScene("TestDrive");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
