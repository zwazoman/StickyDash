using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    public void ScaleUp()
    {
        transform.localScale *= 1.1f;
    }
    public void ScaleDown()
    {
        transform.localScale /= 1.1f;
    }
}
