using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public ScoreManger scoreManager;
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManger>();
    }
    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(other.gameObject); 
        Destroy(other.gameObject);
    }
}
