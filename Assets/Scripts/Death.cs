using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] Explode explode;

    private void Update()
    {
        if (Input.GetKeyDown("r")) Kill();
    }
    public void Kill()
    {
        explode.Scatter();
    }
}
