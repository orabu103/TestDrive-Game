using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTutorial : MonoBehaviour
{
    public GameObject canvasObject;
    //public GameObject quickStartPanel;

    void Start()
    {
        hideQuickStartPanel(); 
    }

    private void Update()
    {
        if (Input.GetKey("k"))
        {
            hideQuickStartPanel(); 
        }
        ;
        //Debug.Log("key k");
    }
    public void CloseCanvas()
    {
        canvasObject.SetActive(false); 
    }

    public void hideQuickStartPanel()
    {
        //quickStartPanel.SetActive(false);
    }
}
