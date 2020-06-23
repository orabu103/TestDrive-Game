using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCarMovement : MonoBehaviour
{
    public GameObject greenCar;
    Animator anim;
    float speed = 0.06f;
    bool isGreenMoving;
    [SerializeField]
    Animation drive;
    // Start is called before the first frame update
    void Awake()
    {
        isGreenMoving = true;
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.Log("Animator Null");
        }
       
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

    public void playAnimation()
    {
        anim.SetBool("Drive!", true);
        StartCoroutine(stopAnumation());
    }
    public IEnumerator stopAnumation()
    {
        yield return new WaitForSecondsRealtime(1f);
        anim.SetBool("Drive!", true);

    }

}
