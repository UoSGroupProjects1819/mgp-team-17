﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private void Update()
    {
        
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.GetComponent<move>().MovesBased)
            {
                //GameManager.Fill with <<moves>> variable += 5f;
            }
            if (other.GetComponent<move>().TimeBased)
            {
                GameManager.timeLeft += 5f;
            }
                
            GameManager.coins += 1;
            other.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, other.GetComponent<SpriteRenderer>().color.a + 0.5f);
            
            FindObjectOfType<AudioManager>().Play("PickUp");
            Destroy(gameObject);



        }

    }
}
