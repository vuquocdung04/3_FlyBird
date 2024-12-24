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
    public Score_Manager score_manager;


    public Audio_Manager audio_manager;

    private void Start()
    {
        player_rb2d = GetComponent<Rigidbody2D>();
        player_ani = GetComponent<Animator>();
        score_manager = FindFirstObjectByType<Score_Manager>();
        audio_manager = FindFirstObjectByType<Audio_Manager>();
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
            audio_manager.Sound_Click();
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
            audio_manager.Sound_Hit();  
            Time.timeScale = 0f;
        }
        if (collision.CompareTag("Score"))
        {
            score_manager.currentScore++;
            score_manager.UpdateHighScore();
            audio_manager.Sound_Point();
        }
    }
}
