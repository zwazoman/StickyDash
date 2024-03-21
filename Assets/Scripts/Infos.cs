using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Infos : MonoBehaviour
{
    [SerializeField] int _dashLimit;
    [SerializeField] TMP_Text dashLimitText;
    Spawn spawn;
    Dash dash;

    private void Awake()
    {
        spawn = GetComponent<Spawn>();
    }
    private void Start()
    {
        dash = spawn.player.GetComponent<Dash>();
        dash.dashLimit = _dashLimit;
        dashLimitText.text = _dashLimit.ToString();
    }

    public void Respawn()
    {
        dash = spawn.player.GetComponent<Dash>();
        dash.dashLimit = _dashLimit;
    }
}

