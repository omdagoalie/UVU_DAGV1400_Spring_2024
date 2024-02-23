using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script22_Instantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
    //Rocket Destruction
    void Start()
    {
        Destroy (gameObject, 1.5f);
    }
}

