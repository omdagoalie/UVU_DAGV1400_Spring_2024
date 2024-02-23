using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script14_DestroyBasic : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    //Part of Destroy Other
    public GameObject other;
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //DestroyBasic
            Destroy(gameObject);

            //DestroyOther
            Destroy(other);

            //DestroyComponent
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
