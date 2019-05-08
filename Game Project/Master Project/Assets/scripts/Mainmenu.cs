using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public void LoadNormalMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TimeAttack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void Quit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Quit2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void Level6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void Level7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void Level8()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
    public void Level9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }

    public void Level10()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
    public void OptionsM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 27);
    }
    public void LevelSelectionN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
    }
    public void Backto1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }
    public void backspaceN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 15);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 14);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }
    public void LoadLevel6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);

    } public void LoadLevel7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
    public void LoadLevel1T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadLevel2T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void LoadLevel3T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void LoadLevel4T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void LoadLevel5T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void LoadLevel6T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void LoadLevel7T()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
}
public void LoadLevel8T()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
}
public void LoadLevel9T()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
}
public void LoadLevel10T()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
}
public void OptionsT()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 24);
}
public void LoadLevel1TT()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
    public void LoadMenu()
    { 
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 19);
}
}