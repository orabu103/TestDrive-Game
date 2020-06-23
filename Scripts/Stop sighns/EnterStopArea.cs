using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStopArea : MonoBehaviour
{
    public GameObject textAnimation_1;
    public GameObject textAnimation_2;
    public GameObject textAnimation_3;
    public GameObject exitCollider; 
    // Start is called before the first frame update
    private IEnumerator OnTriggerEnter(Collider other)
    {
        
        //StartCoroutine(startAnimation());
        print("activating animation");
        yield return new WaitForSecondsRealtime(1);
        textAnimation_1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        textAnimation_2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        textAnimation_3.SetActive(true);
       
        Scoring.scoreAmount += 5;
        //Destroy(exitCollider);
        exitCollider.SetActive(false);
        yield return new WaitForSecondsRealtime(7);
        exitCollider.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        
        print("Scoring.scoreAmount += 100;");

    }

    public IEnumerator startAnimation()
    {
        
        print("activating animation");
        yield return new WaitForSecondsRealtime(1);
        textAnimation_1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        textAnimation_2.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        textAnimation_3.SetActive(true);

        Destroy(exitCollider);
        Scoring.scoreAmount += 10;
        print("Scoring.scoreAmount += 100;");
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
