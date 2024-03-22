using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject winPanel;
    [SerializeField] TMP_Text deathMeter;
    [SerializeField] Pause pause;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
            deathMeter.text = pause.deathMeter.ToString() + " tries";
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        winPanel.SetActive(false);
    }
}
