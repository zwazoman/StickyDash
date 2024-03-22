using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] List<Explode> explodeList = new List<Explode>();
    Spawn spawn;
    Pause pause;
    LeverList leverList;
    [SerializeField] Infos infos;
    private void Awake()
    {
        spawn = FindObjectOfType<Spawn>();
        pause = FindObjectOfType<Pause>();
        leverList = FindObjectOfType<LeverList>();
    }

    private void Update()
    {
        if(Time.timeScale != 0)
        {
            if (Input.GetKeyDown("r")) 
            {
                print("MEURS");
                Kill(); 
            }
        }

    }
    public void Kill()
    {
        foreach (Explode explode in explodeList)
        {
            explode.gameObject.transform.parent = null;
            AudioManager.Instance.PlaySFX(AudioManager.Instance.deathSound,0.2f,1);
            explode.Scatter();
        }
        spawn.Respawn();
        pause.deathMeter += 1;
        if (!leverList.activeLever) leverList.AllLevers();
        Destroy(gameObject);
    }
}
