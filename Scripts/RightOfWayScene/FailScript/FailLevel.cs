using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailLevel : MonoBehaviour
{

    
    public GameObject paramedics;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(3f); 
        paramedics.GetComponent<Animator>().Play("paramedicsAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
