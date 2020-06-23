using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarTutorial : MonoBehaviour
{
    public GameObject cameraAngles;
    public GameObject carStart;
    public GameObject acceleration;
    public GameObject heandBreak;
    public GameObject reverse;
    public GameObject lastText;

    public bool cameraAnglesWasPressed;
    public bool carStartWasPressed;
    public bool heandBreakWasPressed;
    public bool reverseWasPressed;
    private bool accelerationWasPressed;

    void Start()
    {
        cameraAngles.SetActive(true);
        cameraAnglesWasPressed = false;
        carStartWasPressed = false;
        heandBreakWasPressed = false;
        reverseWasPressed = false;
        accelerationWasPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("c") && cameraAnglesWasPressed == false)
        {
            cameraAnglesWasPressed = true;
            cameraAngles.SetActive(false);
            carStart.SetActive(true);
        }

        if (Input.GetKeyDown("k") && carStartWasPressed == false)
        {
            carStartWasPressed = true;
            carStart.SetActive(false);
            acceleration.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && accelerationWasPressed == false)
        {
            accelerationWasPressed = true;
            cameraAngles.SetActive(false);
            
        }


        if (Input.GetKeyDown("r") && heandBreakWasPressed == true)
        {
            
            heandBreak.SetActive(false);
            StartCoroutine(endTuroeial());
        }
    }


    private IEnumerator endTuroeial()
    {
        yield return new WaitForSecondsRealtime(5f);
        reverse.SetActive(false);
        lastText.SetActive(true);
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene("Right lane"); 


    }
}
