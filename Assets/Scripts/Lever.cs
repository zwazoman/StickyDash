using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] Sprite leverActivated; // Jaune
    [SerializeField] Sprite leverDesactivated; // violet

    SpriteRenderer SR;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    public void Activate()
    {
        SR.sprite = leverDesactivated;
    }
    public void Desactivate()
    {
        SR.sprite = leverActivated;
    }


        
    
}
