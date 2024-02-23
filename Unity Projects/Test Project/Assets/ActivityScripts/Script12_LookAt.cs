using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script12_LookAt : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
}
