using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Optionbutton : MonoBehaviour
{

    public GameObject yellowCar;
    public GameObject greenCar;
    public GameObject redCar;
    public GameObject accidentBTrigger;
    public GameObject answerATrigger;
    public GameObject driveForwardText;
    public GameObject arrows;
    bool carfliped;
    bool isAactivated;
    bool isBactivated;
    bool isCactivated;

    private void Start()
    {
        carfliped = false;
    }
    void Update()
    {
        
           
        
    }


    
        public void activateText()
    {
        arrows.SetActive(false);
        answerATrigger.SetActive(true);
        accidentBTrigger.SetActive(false);
        driveForwardText.SetActive(true);
    }
    public void OptionA()
    {

        StartCoroutine(GenerateOppA());
    }

    private IEnumerator GenerateOppA()
    {
        driveForwardText.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        driveForwardText.SetActive(false);
        yield return new WaitForSecondsRealtime(3f);
        accidentBTrigger.SetActive(false);
        greenCar.GetComponent<Animator>().Play("GreenCarAnimation");
        yield return new WaitForSecondsRealtime(5f);
        yellowCar.GetComponent<Animator>().Play("YellowCarSecond");
        yield return new WaitForSecondsRealtime(3f);
        redCar.GetComponent<Animator>().Play("MoveRedCar");
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("PassRightOfWay");


    }


    public void OptionB()
    {

        StartCoroutine(GenerateOppB());
    }

    private IEnumerator GenerateOppB()
    {
        arrows.SetActive(false);
        answerATrigger.SetActive(false);
        accidentBTrigger.SetActive(true);
        yellowCar.GetComponent<Animator>().Play("YellowCarSecond");
        yield return new WaitForSecondsRealtime(3f);
        driveForwardText.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        driveForwardText.SetActive(false);

        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("FailRightOfWay"); 

    }


    public void OptionC()
    {
        arrows.SetActive(false); 
        if(carfliped == false)
        {
            StartCoroutine(GenerateOppC());
            carfliped = true;
        }
        
    }

    private IEnumerator GenerateOppC()
    {
        accidentBTrigger.SetActive(true);
        yellowCar.GetComponent<Animator>().Play("YellowCarAccident");
        yield return new WaitForSecondsRealtime(1f);
        redCar.GetComponent<Animator>().Play("RedCarAccidentC");
        yield return new WaitForSecondsRealtime(0.5f);
        yellowCar.GetComponent<Animator>().Play("YellowCarUp side down");
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene("FailRightOfWay");
    }
}
