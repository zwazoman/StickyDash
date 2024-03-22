using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] Sprite leverActivated; // Jaune
    [SerializeField] Sprite leverDesactivated; // violet

    SpriteRenderer SR;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("ActivateLevers");
    }

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    public void Activate()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.leverSound, 1, 1);
        SR.sprite = leverDesactivated;
    }
    public void Desactivate()
    {
        AudioManager.Instance.PlaySFX2(AudioManager.Instance.leverSound, 1, 1);
        SR.sprite = leverActivated;
    }


        
    
}
