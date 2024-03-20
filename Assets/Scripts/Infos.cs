using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infos : MonoBehaviour
{
    [SerializeField] int _dashLimit;
    Spawn spawn;
    Dash dash;

    private void Awake()
    {
        spawn = GetComponent<Spawn>();
    }

    public void Respawn()
    {
        dash = spawn.player.GetComponent<Dash>();
        dash.dashLimit = _dashLimit;
    }
}

