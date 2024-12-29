using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_Manager : MonoBehaviour
{
    public GameObject PopUp_EndGame;
    private void Start()
    {
        PopUp_EndGame.SetActive(false);
    }

    private void Update()
    {
        Check_EndGame();
    }
    void Check_EndGame()
    {
        if (GameController.Instance.PlayerContrains.playerController.checkGameOver)
        {
            PopUp_EndGame.SetActive(true);
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void BackHome()
    {
        SceneManager.LoadScene("PopUp_Scene");
    }
}
