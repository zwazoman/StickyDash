using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    public int deathMeter;
    [SerializeField] TMP_Text deathMeterText;
    Spawn spawn;

    private void Awake()
    {
        spawn = GetComponent<Spawn>();
    }
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (pausePanel.activeSelf)
            {
                Resume();
                return;
            }
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            deathMeterText.text = deathMeter.ToString() + " tries";
        }
    }
    public void Resume()
    {
        Time.timeScale = 1;
        print("suu");
        pausePanel.SetActive(false);
    }

    public void Retry()
    {
        spawn.player.GetComponent<Death>().Kill();
    }
}
