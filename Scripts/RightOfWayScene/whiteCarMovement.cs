using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteCarMovement : MonoBehaviour
{
    public GameObject greenCar;

    float speed = 0.06f;
    bool isGreenMoving;
    // Start is called before the first frame update
    void Start()
    {
        isGreenMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGreenMoving)
        {
            moveGreenForward();
        }
    }


    public void moveGreenForward()
    {

        greenCar.transform.position += new Vector3(0, 0, speed);
    }


    public void StopGreenCar()
    {
        print("in StopGreenCar()");
        isGreenMoving = false;
    }

}
