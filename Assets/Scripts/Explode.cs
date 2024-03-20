using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Scatter()
    {
        rb.simulated = !rb.simulated;
        rb.simulated = !rb.simulated;

    }
}
