using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Lvl1()
    {
        SceneManager.LoadScene("LVL 1");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("LVL 2");
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("LVL 3");
    }
    public void Lvl4()
    {
        SceneManager.LoadScene("LVL 4");
    }
    public void Lvl5()
    {
        SceneManager.LoadScene("LVL 5");
    }
    public void Lvl6()
    {
        SceneManager.LoadScene("LVL 6");
    }
    public void LeaveGame()
    {
        Application.Quit();
        print("you left");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
