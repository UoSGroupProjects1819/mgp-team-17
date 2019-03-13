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

    public int points=0;
    

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
    }

    void FixedUpdate()
    {

        if (ableToMove == true)
        {
            if (Input.GetKey("a") && disableA == false)
            {
                rb.AddForce(Vector3.left * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = true;
                disableW = false;
                disableS = false;
                disableD = false;
                GameManager.moveNum -=1;
                return;

            }
            if (Input.GetKey("d") && disableD == false)
            {
                rb.AddForce(Vector3.right * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = false;
                disableS = false;
                disableD = true;
                GameManager.moveNum -= 1;
                return;


            }
            if (Input.GetKey("w") && disableW == false)
            {

                rb.AddForce(Vector3.up * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = true;
                disableS = false;
                disableD = false;
                GameManager.moveNum -= 1;
                return;


            }
            if (Input.GetKey("s") && disableS == false)
            {
                rb.AddForce(Vector3.down * thrust * Time.deltaTime, ForceMode2D.Impulse);
                ableToMove = false;
                disableA = false;
                disableW = false;
                disableS = true;
                disableD = false;
                GameManager.moveNum -=1;
                return;

            }

        }
        

    }

    
        


    

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Key"))
    //    {
    //        other.gameObject.SetActive(false);
    //        countKeys += 1;
    //        SetCountText();
    //    }
    //}

    //void SetCountText()
    //{
    //    countKeysText.text = "Keys: " + countKeys.ToString();

    //}

    
}