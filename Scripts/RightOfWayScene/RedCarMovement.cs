using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCarMovement : MonoBehaviour
{
    public GameObject redCar;

    float speed = 0.06f;
    bool isRedMoving;
    // Start is called before the first frame update
    void Start()
    {
        //isRedMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRedMoving)
        {
            moveRedForward();
        }
    }


    public void moveRedForward()
    {
        isRedMoving = true;
        redCar.transform.position += new Vector3(0, 0, -speed);
    }


    public void StopRedCar()
    {
        print("in StopGreenCar()");
        isRedMoving = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
