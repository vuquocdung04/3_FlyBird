using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public TMP_Text Text_CurrentScore;
    public TMP_Text Text_HighScore;

    public int currentScore;
    public int highScore;

    public void Init(PlayerContrains name)
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        Text_HighScore.text = "HI: " + highScore.ToString();
    }
    private void Update()
    {
        Text_CurrentScore.text = currentScore.ToString();
    }
    public void UpdateHighScore()
    {
        if (currentScore >= highScore)
        {
            highScore = currentScore;
            Text_HighScore.text = "HI: " + highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
