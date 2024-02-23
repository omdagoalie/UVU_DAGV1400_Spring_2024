using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Script18_getComponent : MonoBehaviour
{
    /*
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The Player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberofPlayerDeaths + "times");
    }
    */

    //Another Script
    public int playerScore = 9001;

    //Yet Another Script
    public int numberOfPlayerDeaths = 3;
}
