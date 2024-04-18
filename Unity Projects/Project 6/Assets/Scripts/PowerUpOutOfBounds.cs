using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float loweBounds= -10.0f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds){
            Destroy(gameObject);
        }
        else if(transform.position.z < loweBounds){
            Destroy(gameObject);
        }
    }
}
