using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script9_EnableAndDisable : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
