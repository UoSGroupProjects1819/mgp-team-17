using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppExit : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}
