using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionCamera : MonoBehaviour
{
    public GameObject camera; 
    private void OnTriggerEnter(Collider other)
    {
        print("camera"); 
        camera.SetActive(true); 
    }
}
