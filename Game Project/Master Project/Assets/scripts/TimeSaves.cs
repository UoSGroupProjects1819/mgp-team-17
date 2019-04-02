using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSaves : MonoBehaviour
{
    int sceneIndex;
    int levelPassed;

    void Start()
    {



        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("timelevelpassed");

        Debug.Log(sceneIndex);

        Debug.Log(levelPassed);

        Win();

    }

    public void Win()
    {


        PlayerPrefs.SetInt("timelevelpassed", sceneIndex - 12);


    }

}
