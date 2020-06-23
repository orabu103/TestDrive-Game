using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heandBreakTrigger : MonoBehaviour
{
    public GameObject carAcceleration;
    public GameObject heandBreakText;
    public CarTutorial carTutorial;
    [SerializeField]
    public GameObject go;

    public void Start()
    {
        carTutorial = go.GetComponent<CarTutorial>();
    }
    private void OnTriggerEnter(Collider other)
    {
        print("head break collider");                     
        carTutorial.heandBreakWasPressed = true;
        carAcceleration.SetActive(false);
        heandBreakText.SetActive(true);
        StartCoroutine(startReverseMessage());
    }

    private IEnumerator startReverseMessage()
    {
        yield return new WaitForSecondsRealtime(5f);
        heandBreakText.SetActive(false);
        yield return new WaitForSecondsRealtime(5f);
        carTutorial.reverse.SetActive(true);
        yield return new WaitForSecondsRealtime(10f);


    }
}
