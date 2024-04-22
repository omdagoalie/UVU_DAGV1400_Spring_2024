using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject gameOverText;
    public AudioSource musicAudio;
    public AudioSource soundEffect;
    public AudioClip backgroundMusic;
    public AudioClip gameOver;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverTxt");
        musicAudio.clip = backgroundMusic;
        soundEffect.clip = gameOver;
        musicAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {

            EndGame();
            Debug.Log("Called Endgame");
            musicAudio.Stop();
            soundEffect.Play();
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
