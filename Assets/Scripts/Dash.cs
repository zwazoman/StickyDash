using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    internal bool onTop;
    internal bool onBottom;
    internal bool onLeft;
    internal bool onRight;
    internal bool canDash = true;
    float rayLength = 1f;
    public LayerMask layerMask;
    Rigidbody2D rb;
    [SerializeField] float dashForce;
    //METS TOUT EN TRIGGER FDP

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canDash) 
            {
                Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouseWorldPosition.z = 0;
                Vector3 dashDirection = mouseWorldPosition - transform.position;
                if (Physics2D.Raycast(transform.position, Vector2.down, rayLength, layerMask.value)/*onTop*/ && mouseWorldPosition.y<transform.position.y)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.up, rayLength, layerMask.value)/*onBottom*/ && mouseWorldPosition.y > transform.position.y)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.left, rayLength, layerMask.value)/*onRight*/ && mouseWorldPosition.x < transform.position.x)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.right, rayLength, layerMask.value)/*onLeft*/ && mouseWorldPosition.x > transform.position.x)
                {
                    print("nope");
                    return;
                }
                rb.velocity = dashDirection.normalized * dashForce;
                //transform.Translate(dashDirection * dashForce * Time.deltaTime);
                canDash = false;
                print("dash");
                //son dash
            }
            else
            {
                print("can't dash");
            }
            
        }

    }
}
