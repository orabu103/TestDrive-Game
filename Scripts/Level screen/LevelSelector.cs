using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadLevel_1()
    {
        SceneManager.LoadScene("CarController");
    }
    public void LoadLevel_2()
    {
        SceneManager.LoadScene("Right lane");
    }
    public void LoadLevel_3()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void LoadLevel_4()
    {
        SceneManager.LoadScene("StopSignTutorial"); 
    }
    public void LoadLevel_5()
    {
        SceneManager.LoadScene("TrafficLightsTutorial");
    }
    public void LoadLevel_6()
    {
        SceneManager.LoadScene("SpeedTutorial");
    }
    public void LoadLevel_7()
    {
        SceneManager.LoadScene("RightOfWay");
    }

    public void LoadLevel_8()
    {
        SceneManager.LoadScene("PedestrianCrossing");
    }
    public void LoadTestDrive()
    {
        SceneManager.LoadScene("TestDrive");
    }

}
