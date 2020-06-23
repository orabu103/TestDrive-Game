using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopYellowCarTrigger : MonoBehaviour
{
    public YellowCar car;
    public GameObject stopTrigger;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
       if(other.name=="YellowCar")
        {
            car.StopYellowCar();
            stopTrigger.SetActive(false);
        }
    }

}
