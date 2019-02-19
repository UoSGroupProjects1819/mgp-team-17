using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public float timeLeft = 180f;
    public Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        SetTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        SetTimerText();
        if (timeLeft < 0)
        {
            Debug.Log("gameover");
            timeLeft = 1;
        }
    }

    void SetTimerText()
    {
        int timeLeftint = (int)timeLeft;
        timerText.text = "Time left: " + timeLeftint.ToString();

    }
    //int myBlubb = (int)myFloatBlubb;
}
