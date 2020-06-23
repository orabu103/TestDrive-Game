using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSignal : MonoBehaviour
{
   
    bool isRightFlicker; 
    public Light rightSignal;
    public LeftSignal L_light; 


    // Start is called before the first frame update
    void Start()
    {
        rightSignal = GetComponent<Light>();
         isRightFlicker = false;
        rightSignal.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Right signal
        if (Input.GetKeyDown("x") && isRightFlicker == false)
        {
            L_light.closeLight(L_light.leftSignal); 
            print("x is pressed");
            isRightFlicker = true;
            StartCoroutine(startRightSignal());
        }

        else if (Input.GetKeyDown("x") && isRightFlicker == true)
        {
            isRightFlicker = false;
        }  
    }



    public IEnumerator startRightSignal()
    {  
        while (isRightFlicker == true)
        {
            yield return new WaitForSeconds(0.5f);
            print("in right While");
            rightSignal.enabled = !rightSignal.enabled;
        }
        rightSignal.enabled = false;
    }

    public void closeLight(Light leftLight)
    {
        isRightFlicker = false; 
    }
    
}

    

   

