using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script23_Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number "+i+" is named "+players[i].name);
        }
    }
}
