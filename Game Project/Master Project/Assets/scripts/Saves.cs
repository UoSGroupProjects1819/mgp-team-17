using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saves : MonoBehaviour
{
    public static Saves instance = null;
    int sceneIndex;
    int levelPassed;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }


        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("levelpassed");
    }

    public void Win()
    {
        if (levelPassed < sceneIndex)
        {
            PlayerPrefs.SetInt("levelpassed", sceneIndex);
        }
    }
}
