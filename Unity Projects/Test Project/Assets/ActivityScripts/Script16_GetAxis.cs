using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script16_GetAxis : MonoBehaviour
{
    //public float range;
    //public Text textOutput; Both for Example one and two

    //Dual Axis
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    void Update()
    {
        /*
        Get Axis
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range; 

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
        */
        /*
        Get Axis Raw 
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range; 

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
        */

        //Dual Axis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("vertical");
        float xPos = h * hRange;
        float vPos = v * vRange;

        transform.position = new Vector3(xPos, 0,vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}
