﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1 );
            Debug.Log("boye");
        }


    }
}
