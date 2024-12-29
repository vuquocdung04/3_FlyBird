using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D player_rb2d;
    Animator player_ani;
    public float fly_speed;
    public float rotation_Speed;


    public bool checkGameOver;

    public void Init(PlayerContrains name)
    {
        player_ani = GetComponentInChildren<Animator>();
        player_rb2d = GetComponentInChildren<Rigidbody2D>();
    }

    private void Update()
    {
        Fly();
    }

    private void FixedUpdate()
    {
        RotateFly();
        
    }

    void Fly()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !checkGameOver)
        {
            player_rb2d.velocity = Vector2.up * fly_speed;
            GameController.Instance.PlayerContrains.audioManager.Sound_Click();
        }
    }

    void RotateFly()
    {
        var bird = player_rb2d.velocity.y * rotation_Speed;

        if (bird >= -90 && bird <= 90)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, bird * rotation_Speed);    
        }
        else
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe") || collision.CompareTag("Dir"))
        {
            checkGameOver = true;
            GameController.Instance.PlayerContrains.audioManager.Sound_Hit();  
            Time.timeScale = 0f;
        }
        if (collision.CompareTag("Score"))
        {
            GameController.Instance.PlayerContrains.scoreManager.currentScore++;
            GameController.Instance.PlayerContrains.scoreManager.UpdateHighScore();
            GameController.Instance.PlayerContrains.audioManager.Sound_Point();
        }
    }
}
