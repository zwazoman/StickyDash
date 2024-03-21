using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    bool activateLever = true;
    [SerializeField] Sprite leverActivated; // Jaune
    [SerializeField] Sprite leverDesactivated; // violet
    [SerializeField] List<GameObject> yellowWalls = new List<GameObject>();
    [SerializeField] List<GameObject> purpleWalls = new List<GameObject>();
    SpriteRenderer SR;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    public void Activate()
    {
        activateLever = !activateLever;
        if (activateLever)
        {
            SR.sprite = leverActivated;
            foreach (GameObject yellowWall in yellowWalls)
            {
                yellowWall.SetActive(false);
            }
            foreach (GameObject purpleWall in purpleWalls)
            {
                purpleWall.SetActive(true);
            }
        }
        else
        {
            SR.sprite = leverDesactivated;
            foreach (GameObject yellowWall in yellowWalls)
            {
                yellowWall.SetActive(true);
            }
            foreach (GameObject purpleWall in purpleWalls)
            {
                purpleWall.SetActive(false);
            }
        }
    }
}
