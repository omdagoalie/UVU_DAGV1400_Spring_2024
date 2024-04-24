using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        if(Time.timeScale == 0){
            Destroy(gameObject);
        }
    }
}
