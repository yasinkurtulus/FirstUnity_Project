using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    public float speed;
    public float maxspeed;

    Rigidbody2D rb;
    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       
    }

    void Update()
    {
        PaddleMovement();  
    }
    private void PaddleMovement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = new Vector2(-speed, 0);
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector2(speed, 0);
        else
            rb.velocity = Vector2.zero;
    }
}
