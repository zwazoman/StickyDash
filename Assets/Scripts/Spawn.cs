using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Infos infos;
    internal GameObject player;
    Vector2 spawnPosition;
    Quaternion spawnRotation;

    private void Awake()
    {
        player = playerPrefab;
    }
    void Start()
    {
        spawnPosition = spawnPoint.transform.position;
        spawnRotation = spawnPoint.transform.rotation;
        player = Instantiate(playerPrefab, spawnPosition, spawnRotation);
    }

    public void Respawn()
    {
        player = Instantiate(playerPrefab, spawnPosition, spawnRotation);
        infos.Respawn();
    }
}
