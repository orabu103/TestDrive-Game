using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryAgain : MonoBehaviour
{
   public void onTryAgainClick()
    {
        SceneManager.LoadScene("TestDrive");
    }
}
