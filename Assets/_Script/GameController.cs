using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public PlayerContrains PlayerContrains;

    protected override void OnAwake()
    {
        Init();
    }

    void Init()
    {
        PlayerContrains.Init();
    }
}
