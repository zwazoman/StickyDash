using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverList : MonoBehaviour
{
    [SerializeField] public List<Lever> levers = new List<Lever>();
    [SerializeField] List<GameObject> yellowWalls = new List<GameObject>();
    [SerializeField] List<GameObject> purpleWalls = new List<GameObject>();
    [SerializeField] Sprite enabledYellowWall;
    [SerializeField] Sprite disabledYellowWall;
    [SerializeField] Sprite enabledPurpleWall;
    [SerializeField] Sprite disabledPurpleWall;
    public bool activeLever = true;

    public void AllLevers()
    {
        if (activeLever)
        {
            foreach (Lever lever in levers)
            {
                lever.Activate();
                activeLever = false;
            }
            foreach(GameObject yellowWall in yellowWalls)
            {
                yellowWall.GetComponent<SpriteRenderer>().sprite = enabledYellowWall;
                yellowWall.GetComponent<Collider2D>().enabled = true;
            }
            foreach(GameObject purpleWall in purpleWalls)
            {
                purpleWall.GetComponent<SpriteRenderer>().sprite = disabledPurpleWall;
                purpleWall.GetComponent<Collider2D>().enabled = false;

            }
        }
        else
        {
            foreach (Lever lever in levers)
            {
                lever.Desactivate();
                activeLever = true;
            }
            foreach (GameObject yellowWall in yellowWalls)
            {
                yellowWall.GetComponent<SpriteRenderer>().sprite = disabledYellowWall;
                yellowWall.GetComponent<Collider2D>().enabled = false;
            }
            foreach (GameObject purpleWall in purpleWalls)
            {
                purpleWall.GetComponent<SpriteRenderer>().sprite = enabledPurpleWall;
                purpleWall.GetComponent<Collider2D>().enabled = true;
            }
        }

    }
}
