using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 force_direction;
    Vector3 firstposition;
    TrailRenderer tr;
    private void Awake()
    {
        tr = gameObject.GetComponent<TrailRenderer>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        firstposition = this.gameObject.GetComponent<Transform>().position;
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
        if (collision.gameObject.tag=="downWall")
        {
            tr.emitting = false;
            transform.position = firstposition;
            rb.velocity = Vector2.zero;
            Invoke(nameof(ballfirstmovement), 1f);
            tr.time = 2;
            Invoke(nameof(emmitingtrue), 0.5f);
        }

    }
    public void emmitingtrue()
    {
        tr.emitting = true;
    }
}
