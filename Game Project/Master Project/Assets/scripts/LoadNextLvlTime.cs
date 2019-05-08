using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLvlTime : MonoBehaviour
{

    public TimeSaves saves;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            PlayerPrefs.SetInt("timelevelpassed", SceneManager.GetActiveScene().buildIndex - 16);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}

