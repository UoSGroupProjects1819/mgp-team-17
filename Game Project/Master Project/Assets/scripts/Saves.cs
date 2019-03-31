using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saves : MonoBehaviour
{

    int sceneIndex;
    int levelPassed;
   
    void Start()
    {



        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("levelpassed");

        Debug.Log(sceneIndex);
       
        Debug.Log(levelPassed);

        Win();
        
    }

    public void Win()
    {
        
        
        PlayerPrefs.SetInt("levelpassed", sceneIndex-4);
        
        
    }


}
