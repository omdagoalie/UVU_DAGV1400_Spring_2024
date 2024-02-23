using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4_If : MonoBehaviour
{
    // Start is called before the first frame update
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    void Update()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right");
        }
    }
}
