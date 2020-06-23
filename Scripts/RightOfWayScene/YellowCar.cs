using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCar : MonoBehaviour
{
    public GameObject yellowCar;

    float speed = 0.09f;
    bool isYellowMoving;
    // Start is called before the first frame update
    void Start()
    {
        isYellowMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isYellowMoving)
        {
            moveYellowForward();
        }
    }


    public void moveYellowForward()
    {
        isYellowMoving = true;
        yellowCar.transform.position += new Vector3(speed, 0, 0);
    }


    public void StopYellowCar()
    {
        print("in StopYellowCar()");
        isYellowMoving = false;
    }


}
