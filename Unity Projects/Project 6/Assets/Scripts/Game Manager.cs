using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject gameOverText;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Update()
    {
        if(Time.timeScale == 0)
        {

            EndGame();
            Debug.Log("Called Endgame");
        }
        else
        {
            gameOverText.SetActive(false);
            Debug.Log("its false");
        }
    
}
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        isGameOver = true;
        Time.timeScale = 0;
    }
    
}
