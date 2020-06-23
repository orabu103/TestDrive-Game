using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRedCarTrigger : MonoBehaviour
{
    public RedCarMovement car;


    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "RedCar")
        {
            car.StopRedCar();
        }
    }
}
