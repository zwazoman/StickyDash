using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Cinemachine;

public class Dash : MonoBehaviour
{
    internal bool canDash = true;
    [HideInInspector] public int dashLimit;
    float rayLength = 0.19f;
    public LayerMask layerMask;
    public TMP_Text dashLimitText;
    Rigidbody2D rb;
    public Vector3 dashDirection;
    [SerializeField] float dashForce;
    [SerializeField] GameObject dashSmokeParticle;
    [SerializeField] CinemachineImpulseSource impulseSource;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        dashLimitText = GameObject.Find("DashLimitText").GetComponent<TMP_Text>();
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }
    private void Start()
    {
        dashLimitText.text = dashLimit.ToString();
    }
    private void Update()
    {
        if (Time.timeScale == 0) return; 
      
        if (Input.GetMouseButtonDown(0))
        {
            if (canDash) 
            {
                Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouseWorldPosition.z = 0;
                dashDirection = mouseWorldPosition - transform.position;
                if (Physics2D.Raycast(transform.position, Vector2.down, rayLength, layerMask.value) && mouseWorldPosition.y < transform.position.y)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.up, rayLength, layerMask.value) && mouseWorldPosition.y > transform.position.y)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.left, rayLength, layerMask.value) && mouseWorldPosition.x < transform.position.x)
                {
                    print("nope");
                    return;
                }
                if (Physics2D.Raycast(transform.position, Vector2.right, rayLength, layerMask.value) && mouseWorldPosition.x > transform.position.x)
                {
                    print("nope");
                    return;
                }
                if (dashLimit <= 0)
                {
                    print("plus de dash");
                    return;
                }
                rb.constraints = RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                GameObject smoke = Instantiate(dashSmokeParticle, transform.position, Quaternion.identity);
                Destroy(smoke, 1);
                impulseSource.GenerateImpulseWithForce(0.1f);
                AudioManager.Instance.PlaySFX(AudioManager.Instance.dashSound,1,1);
                rb.velocity = dashDirection.normalized * dashForce;
                canDash = false;
                dashLimit -= 1;
                dashLimitText.text = dashLimit.ToString();
                print("dash");

            }
            else
            {
                print("can't dash");
            }
            
        }

    }
}
