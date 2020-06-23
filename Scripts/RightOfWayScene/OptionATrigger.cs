using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionATrigger : MonoBehaviour
{
    public Optionbutton op_A;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Sport Coupe Collider Top ")
        {
            
            op_A.OptionA();
        }
    }
}
