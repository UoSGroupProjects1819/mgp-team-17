using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMenu : MonoBehaviour
{
    public Button lvl2, lvl3, lvl4, lvl5, lvl6, lvl7;
    int levelPassed;



    void Start()
    {

        levelPassed = PlayerPrefs.GetInt("timelevelpassed");
        Debug.Log(levelPassed);
        lvl2.interactable = false;
        lvl3.interactable = false;
        lvl4.interactable = false;
        lvl5.interactable = false;
        lvl6.interactable = false;
        lvl7.interactable = false;




    }



    public void Update()
    {



        if (levelPassed == 1)
        {
            lvl2.interactable = true;
        }
        else if (levelPassed == 2)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
        }
        else if (levelPassed == 3)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;
        }
        else if (levelPassed == 4)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;
            lvl5.interactable = true;
        }
        else if (levelPassed == 5)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;
            lvl5.interactable = true;
            lvl6.interactable = true;
        }
        else if (levelPassed >= 6)
        {
            lvl2.interactable = true;
            lvl3.interactable = true;
            lvl4.interactable = true;
            lvl5.interactable = true;
            lvl6.interactable = true;
            lvl7.interactable = true;
        }

    }

    public void Reset()
    {

        PlayerPrefs.SetInt("timelevelpassed", 0);
        levelPassed = PlayerPrefs.GetInt("timelevelpassed");
        lvl2.interactable = false;
        lvl3.interactable = false;
        lvl4.interactable = false;
        lvl5.interactable = false;
        lvl6.interactable = false;
        lvl7.interactable = false;
        Debug.Log(levelPassed);
    }

}
