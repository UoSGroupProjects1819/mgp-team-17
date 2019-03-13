using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public int coins = 0;
    static public int keys = 0;
    static public float timeLeft;
    static public int moveNum;
    public float newtimeleft;
    public int newMoveNum;
    public int outOfCoins;
    public int outOfKeys;
    public int outOfMoves;








    public Text movesText;
    public Text keysText;
    public Text timerText;
    public Text coinText;

    private float endtime= 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        moveNum = newMoveNum;
        newMoveNum = moveNum;
        outOfMoves = moveNum;

        timeLeft = newtimeleft;
        newtimeleft = timeLeft;
        
        coins = 0;
        keys = 0;
        SetTimerText();
        SetCoinsText();
        SetKeysText();
        SetMovesText();
        Slides();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        SetTimerText();
        SetCoinsText();
        SetKeysText();
        Slides();
        SetMovesText();
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            timeLeft = newtimeleft;
        }
    }

    void SetTimerText()
    {
        int timeLeftint = (int)timeLeft;
        timerText.text = "Time left: " + timeLeftint.ToString();

    }

    void SetCoinsText()
    {
        coinText.text = "Coins: " + coins.ToString() + "/"+ outOfCoins.ToString();
    }
    


    void SetKeysText()
    {
        keysText.text = "Keys: " + keys.ToString() + "/" + outOfKeys.ToString();
    }

    void SetMovesText()
    {
        movesText.text = "Moves: " + moveNum.ToString() + "/" + outOfMoves.ToString(); 
    }

    void Slides()
    {
        if (moveNum <= 0)
        {
            
            movesLoseDelay();
            move.ableToMove = false;
            return;

        }
    }

    void movesLoseDelay()
    {
        endtime -= Time.deltaTime;
        if (endtime < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }







    //int myBlubb = (int)myFloatBlubb;

}
