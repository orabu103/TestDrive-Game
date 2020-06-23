using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonChooser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tryAgainButton()
    {
        SceneManager.LoadScene("RightOfWay");
    }
    public void mainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
