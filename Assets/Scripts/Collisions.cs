using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Dash dashScript;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dashScript.canDash = true;
        rb.velocity = Vector2.zero;
        rb.simulated = false;
        print("au mur");
    }

}
