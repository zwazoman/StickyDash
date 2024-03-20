using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject initialPlayer;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Infos infos;
    internal GameObject player;
    Vector2 initialPlayerPosition;
    Quaternion initialPlayerRotation;

    private void Awake()
    {
        player = playerPrefab;
    }
    void Start()
    {
        initialPlayerPosition = initialPlayer.transform.position;
        initialPlayerRotation = initialPlayer.transform.rotation;
    }

    public void Respawn()
    {
        player = Instantiate(playerPrefab, initialPlayerPosition, initialPlayerRotation);
        infos.Respawn();
    }
}
