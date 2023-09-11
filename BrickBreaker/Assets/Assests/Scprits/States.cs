using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour
{
    public int healt;
    public Sprite[] states;
    public bool unbrekeable;
    SpriteRenderer sr;
    
    private void Awake()
    {
        sr = this.gameObject.GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        if (!unbrekeable){
            healt = states.Length;         
            sr.sprite = states[healt - 1];
                }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ball")
            hit(); 
    }
    public void hit()
    {
        if (!unbrekeable)
        {
            healt--;
            if (healt <= 0)
                this.gameObject.SetActive(false);
            else
            {
                sr.sprite = states[healt - 1];
            }
        }
    }
}
