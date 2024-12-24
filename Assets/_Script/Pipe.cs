using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float pipe_speed = 2f;
    Vector2 getPos;

    int dem = 0;

    private void Start()
    {
        getPos = this.transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        RePos();
    }

    void Move()
    {
        if (dem % 2 == 0)
        {
            this.transform.Translate(Vector2.left * pipe_speed * Time.deltaTime);
        }
        else
            this.transform.Translate(Vector2.right * pipe_speed * Time.deltaTime);
    }

    void RePos()
    {
        float ramdomPos = Random.Range(-2f, 2.5f);
        if (this.transform.position.x < -37f) // + 1pipe -> tang 7
        {
            dem++;
            this.transform.Rotate(0, 0, 180);
            this.transform.position = new Vector2(getPos.x, ramdomPos);
        }
    }
}
