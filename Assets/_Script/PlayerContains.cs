using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContrains : MonoBehaviour
{
    public PlayerController playerController;
    public Score_Manager scoreManager;
    public Audio_Manager audioManager;
    public PipeSpawner pipeSpawner;


    public void Init()
    {
        playerController.Init(this);
        scoreManager.Init(this);
    }
}
