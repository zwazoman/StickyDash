using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Lvl1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 1");
    }
    public void Lvl2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 2");
    }
    public void Lvl3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 3");
    }
    public void Lvl4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 4");
    }
    public void Lvl5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 5");
    }
    public void Lvl6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL 6");
    }
    public void LeaveGame()
    {
        Application.Quit();
        print("you left");
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
