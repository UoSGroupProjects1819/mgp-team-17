using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{

    public GameObject PauseMenuUI;

    public void PauseScreen()
    {
        PauseMenuUI.SetActive(true);
    }
    public void PauseScreenOff()
    {
        PauseMenuUI.SetActive(false);
    }


} 



    
    
