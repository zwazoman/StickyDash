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
        dashScript.canDash = true;
        rb.velocity = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        print("au mur");
        if (collision.gameObject.layer == 7) // si win object
        {
            print("you won");
            //panel win
            Time.timeScale = 0;
        }
        if (collision.gameObject.layer == 8) // si pics
        {
            death.Kill();
            //panel loose
            Time.timeScale = 0;
        }
        if (collision.gameObject.layer == 9) // si bumper
        {
            //son boing
            GameObject bumper = collision.gameObject;
            rb.velocity = dashScript.dashDirection;
        }
        if (collision.gameObject.layer == 10) // si levier
        {
            lever = collision.gameObject;
            lever.SendMessage("Connard");
        }
    }

}
