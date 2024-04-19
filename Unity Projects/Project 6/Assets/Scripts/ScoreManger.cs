using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Update is called once per frame
    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
