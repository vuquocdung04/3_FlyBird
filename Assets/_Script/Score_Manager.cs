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


    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        Text_HighScore.text = "HI: " + highScore.ToString();
    }
    private void Update()
    {
        Text_CurrentScore.text = currentScore.ToString();
    }

    private void FixedUpdate()
    {
        TangToc();
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
    void TangToc()
    {
        switch (currentScore)
        {
            case > 105:
                Time.timeScale = 2f;
                break;
            case > 75:
                Time.timeScale = 1.8f;
                break;
            case > 55:
                Time.timeScale = 1.6f;
                break;
            case > 35:
                Time.timeScale = 1.4f;
                break;
            case > 15:
                Time.timeScale = 1.2f;
                break;
        }
    }
}
