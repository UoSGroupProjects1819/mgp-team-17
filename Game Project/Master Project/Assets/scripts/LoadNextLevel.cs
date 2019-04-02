using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{

    public Saves saves;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {

            PlayerPrefs.SetInt("levelpassed", SceneManager.GetActiveScene().buildIndex-3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
