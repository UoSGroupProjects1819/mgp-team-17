using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private void Update()
    {
        
        Debug.Log(GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color.a);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.timeLeft += 5f;
            GameManager.coins += 1;
            other.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, other.GetComponent<SpriteRenderer>().color.a + 0.5f);
            Destroy(gameObject);
            


        }

    }
}
