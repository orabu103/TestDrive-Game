using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChooser : MonoBehaviour
{
    GameObject tryAgainButton;
    GameObject mainMenuButton;

    public void GoTotryAgain()
    {
        SceneManager.LoadScene("PedestrianCrossing");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GoTotryAgain_TrafficLights()
    {
        SceneManager.LoadScene("TrafficLightsTutorial");
    }

}
