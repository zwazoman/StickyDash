using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Death death;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Dash dashScript;
    GameObject lever;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            dashScript.canDash = true;
            rb.velocity = Vector2.zero;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            print("collé au mur");
        }

        if (collision.gameObject.tag == "Win") // si win object
        {
            print("you won");
            //panel win
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "Spikes") // si pics
        {
            print("meurs");
            death.Kill();
            //panel loose
        }
        if (collision.gameObject.layer == 9) // si bumper
        {
            //son boing
        }
        if (collision.gameObject.tag == "Lever") // si levier
        {
            lever = collision.gameObject;
            lever.SendMessage("Activate");
        }
    }

}
