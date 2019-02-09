using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    
    public Rigidbody2D rb;
    public float velocity;
    public bool ableToMove;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ableToMove = true;
    }

   
    private void FixedUpdate()
    {

        if (ableToMove == true)
        {
            if (Input.GetKey("a"))
            {
                rb.velocity = new Vector2(-velocity, 0.0f);
                ableToMove = false;

            }
            if (Input.GetKey("d"))
            {
                rb.velocity = new Vector2(velocity, 0.0f);
                ableToMove = false;

            }
            if (Input.GetKey("w"))
            {
                rb.velocity = new Vector2(0.0f, velocity);
                ableToMove = false;

            }
            if (Input.GetKey("s"))
            {
                rb.velocity = new Vector2(0.0f, -velocity);
                ableToMove = false;

            }

        }
        else
            Debug.Log("can't move");

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            rb.velocity = new Vector2(0.0f, 0.0f);

            ableToMove = true;
        }
            


    }
}