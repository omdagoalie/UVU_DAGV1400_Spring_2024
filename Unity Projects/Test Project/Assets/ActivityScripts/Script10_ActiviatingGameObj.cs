using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script10_ActiviatingGameObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myObject;
    void Start()
    {
        //ActiveObjects
        //gameObject.SetActive(false);

        Debug.Log("Active self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
