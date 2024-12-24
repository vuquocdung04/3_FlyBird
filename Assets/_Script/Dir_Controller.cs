using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dir_Controller : MonoBehaviour
{
    public float dir_speed = 5f;

    SpriteRenderer dir_sprite;
    Vector2 getPos;
    private void Start()
    {
        getPos = this.transform.position;
        dir_sprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        DirMove();
    }
    private void FixedUpdate()
    {
        RePosition();
    }


    void DirMove()
    {
        this.transform.Translate(Vector2.left * dir_speed * Time.deltaTime);
    }

    void RePosition()
    {
        if (Mathf.Abs(this.transform.position.x - getPos.x) >= 24)
        {
            this.transform.position = getPos;
        }
    }

}
