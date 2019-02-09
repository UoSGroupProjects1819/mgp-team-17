using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody2D rb;
    public float thrust;
    public bool ableToMove;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ableToMove = true;
    }

    // Update is called once per frame
    void Update()
    {



    }
    private void FixedUpdate()
    {

        if (ableToMove == true)
        {
            if (Input.GetKey("a"))
            {
                rb.AddForce(Vector3.left * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;

            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(Vector3.right * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;

            }
            if (Input.GetKey("w"))
            {
                rb.AddForce(Vector3.up * thrust / 100);
                rb.AddForce(Vector3.up * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;

            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(Vector3.down * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;

            }

        }
        else
            Debug.Log("can't move");

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        ableToMove = true;


    }
}