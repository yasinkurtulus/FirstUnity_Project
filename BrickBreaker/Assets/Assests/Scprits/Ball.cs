using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 force_direction;
    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Invoke(nameof(ballfirstmovement), 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ballfirstmovement()
    {
        float random = Random.Range(-3, 3);
        force_direction.x = random;
        force_direction.y = -1;
        rb.AddForce(force_direction.normalized * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LeftWall")
        {
            Vector2 force = new Vector2(-rb.velocity.x, rb.velocity.y).normalized;
            rb.AddForce(force*10);
            
        }
        if (collision.gameObject.tag == "RightWall")
        {
            Vector2 force = new Vector2(-rb.velocity.x, rb.velocity.y);
            rb.AddForce(force*15);
        }
    }
}
