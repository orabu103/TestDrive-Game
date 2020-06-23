using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGreenCarTrigger : MonoBehaviour
{
    public GreenCarMovement car;


    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "GreenCar")
        {
            car.StopGreenCar();
        }
    }

}
