using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Death death;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Dash dashScript;
    [SerializeField] GameObject hitWallParticle;
    LeverList leverList;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        leverList = FindObjectOfType<LeverList>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            dashScript.canDash = true;
            rb.velocity = Vector2.zero;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            AudioManager.Instance.PlaySFX(AudioManager.Instance.impactSound, 1, Random.Range(0.8f, 1.2f));
            print("collé au mur");
        }
        if (collision.gameObject.tag == "Win") // si win object
        {
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "Spikes") // si pics
        {
            print("pics");
            death.Kill();
        }
        if (collision.gameObject.layer == 9) // si bumper
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.bumperSound,1,1);
        }
    }

    public void ActivateLevers()
    {
        leverList.AllLevers();
    }

}
