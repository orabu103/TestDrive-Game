using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acciden_B : MonoBehaviour
{
    public GameObject redCar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        print(other.name); 
        if(other.name == "Sport Coupe Collider Top ")
        {
            print("in onTriggerRedCar");
            redCar.GetComponent<Animator>().Play("fastCar"); 
        }
    }

}
