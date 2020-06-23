using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSignal : MonoBehaviour
{

    public Light leftSignal;
    bool isLeftFlicker;
    public RightSignal rightSignal; 


    // Start is called before the first frame update
    void Start()
    {
        leftSignal = GetComponent<Light>();
        leftSignal.enabled = false;
        isLeftFlicker = false;


    }

    // Update is called once per frame
    void Update()
    {
        //Left signal
        if (Input.GetKeyDown("z") && isLeftFlicker == false)
        {
            rightSignal.closeLight(rightSignal.rightSignal);
            print("z is pressed");
            isLeftFlicker = true;
            StartCoroutine(startLeftSignal());
        }

        else if (Input.GetKeyDown("z") && isLeftFlicker == true)
        {
            isLeftFlicker = false;


        }
    }



    public IEnumerator startLeftSignal()
    {

        while (isLeftFlicker == true)
        {

            yield return new WaitForSeconds(0.5f);
            print("in left While");
            leftSignal.enabled = !leftSignal.enabled;

        }
        leftSignal.enabled = false;
    }

    public void closeLight(Light leftLight)
    {
        isLeftFlicker = false;
    }

}
