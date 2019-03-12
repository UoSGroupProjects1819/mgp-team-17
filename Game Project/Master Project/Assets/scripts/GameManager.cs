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
    public float newtimeleft;
    public int outOfKeys;
    public int outOfCoins;




    public Text keysText;
    public Text timerText;
    public Text coinText;
    
    // Start is called before the first frame update
    void Start()
    {
        
        timeLeft = newtimeleft;
        newtimeleft = timeLeft;
        coins = 0;
        keys = 0;
        SetTimerText();
        SetCoinsText();
        SetKeysText();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        SetTimerText();
        SetCoinsText();
        SetKeysText();
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
        coinText.text = "Coins: " + coins.ToString() + "/"+ outOfCoins;
    }

    void SetKeysText()
    {
        keysText.text = "Keys: " + keys.ToString() + "/" + outOfKeys;
    }
    //int myBlubb = (int)myFloatBlubb;


    
}
