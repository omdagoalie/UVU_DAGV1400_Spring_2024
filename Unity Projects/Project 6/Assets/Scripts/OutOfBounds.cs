using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float loweBounds= -10.0f;
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds){
            Destroy(gameObject);
        }
        else if(transform.position.z < loweBounds){
            Destroy(gameObject);
            Time.timeScale = 0; 
        }
    }
}
