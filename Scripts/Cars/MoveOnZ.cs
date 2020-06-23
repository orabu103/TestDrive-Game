using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnZ : MonoBehaviour
{
    private float speed = 0.03f;
    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            transform.position += new Vector3(0, 0, speed);
        }
        
            
    }

    public void stop()
    {
        isMoving = false; 
    }

}
