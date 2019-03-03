using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    
   
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.timeLeft += 5f;
            GameManager.coins += 1;
            Destroy(gameObject);


        }

    }
}
