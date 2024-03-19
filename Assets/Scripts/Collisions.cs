using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D coll;
    bool onTop = false;
    bool onBottom = false;
    bool onLeft = false;
    bool onRight = false;
    float rayLength = 0.12f;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Dash dashScript;
    //METS TOUT EN TRIGGER FDP

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }
    private void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, rayLength, layerMask.value))
        {
            onTop = true;
            dashScript.canDash = true;
            rb.velocity = Vector3.zero;
            transform.position = new Vector2(transform.position.x, transform.position.y + rayLength);
            print("onTop");
        }
        else onTop = false;
        dashScript.onTop = onTop;
        if (Physics2D.Raycast(transform.position, Vector2.up, rayLength, layerMask.value))
        {
            onBottom = true;
            dashScript.canDash = true;
            rb.velocity = Vector3.zero;
            transform.position = new Vector2(transform.position.x, transform.position.y - rayLength);
            print("OnBottom");
        }
        else onBottom = false;
        dashScript.onBottom = onBottom;
        if (Physics2D.Raycast(transform.position, Vector2.right, rayLength, layerMask.value))
        {
            onLeft = true;
            dashScript.canDash = true;
            rb.velocity = Vector3.zero;
            transform.position = new Vector2(transform.position.x - rayLength, transform.position.y);
            print("OnLeft");
        }
        else onLeft = false;
        dashScript.onLeft = onLeft;
        if (Physics2D.Raycast(transform.position, Vector2.left, rayLength, layerMask.value))
        {
            onRight = true;
            dashScript.canDash = true;
            rb.velocity = Vector3.zero;
            transform.position = new Vector2(transform.position.x + rayLength, transform.position.y);
            print("onRight");
        }
        else onRight = false;
        dashScript.onRight = onRight;  
    }
}
