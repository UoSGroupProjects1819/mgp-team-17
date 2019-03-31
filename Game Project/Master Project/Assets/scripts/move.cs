﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{

    // Use this for initialization
    public Rigidbody2D rb;
    public float thrust = 200f;
   static public bool ableToMove;
    bool disableW = false;
    bool disableA = false;
    bool disableS = false;
    bool disableD = false;
    public float fadeVar;
    float moves;
    public bool MovesBased = false;
    public bool TimeBased = false;






    void Start()
    {
        


        if (GameManager.moveNum <= 0)
        {
            ableToMove = false;
        }
        

    }

    // Update is called once per frame
    void Update()

    {
        //Debug.Log(fadeVar);
        var speed = rb.velocity.magnitude;

        if (speed > 0.5)
        {
            ableToMove = false;
        }
        else
        {
            ableToMove = true;
        }

        if (GameManager.moveNum <= 0)
        {
            ableToMove = false;
        }
       
        if (TimeBased)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, this.GetComponent<SpriteRenderer>().color.a - fadeVar * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {

        if (ableToMove == true)
        {
            if (Input.GetKey("a") && disableA == false)
            {

                FindObjectOfType<AudioManager>().Play("PlayerMove");
                rb.AddForce(Vector3.left * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = true;
                disableW = false;
                disableS = false;
                disableD = false;
                GameManager.moveNum -=1;
                if (MovesBased)
                {
                    this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, this.GetComponent<SpriteRenderer>().color.a - fadeVar);
                }
               
                return;

            }
            if (Input.GetKey("d") && disableD == false)
            {

                FindObjectOfType<AudioManager>().Play("PlayerMove");
                rb.AddForce(Vector3.right * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = false;
                disableS = false;
                disableD = true;
                GameManager.moveNum -= 1;
                if (MovesBased)
                {
                    this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, this.GetComponent<SpriteRenderer>().color.a - fadeVar);
                }
                return;



            }
            if (Input.GetKey("w") && disableW == false)
            {
                FindObjectOfType<AudioManager>().Play("PlayerMove");
                rb.AddForce(Vector3.up * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = true;
                disableS = false;
                disableD = false;
                
                
                GameManager.moveNum -= 1;
                if (MovesBased)
                {
                    this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, this.GetComponent<SpriteRenderer>().color.a - fadeVar);
                }

                return;


            }
            if (Input.GetKey("s") && disableS == false)
            {
                FindObjectOfType<AudioManager>().Play("PlayerMove");
                rb.AddForce(Vector3.down * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = false;
                disableS = true;
                disableD = false;
                GameManager.moveNum -=1;
                if (MovesBased)
                {
                    this.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, this.GetComponent<SpriteRenderer>().color.a - fadeVar);
                }
                return;

            }

        }
        

    }

    
        


    

    
    
}