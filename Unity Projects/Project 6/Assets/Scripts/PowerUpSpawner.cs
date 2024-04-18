using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerupPrefabs; // Array for UFO's
    public int powerupIndex;
    private float spawnRangeX = 10f;
    private float spawnPosZ = 20f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start(){
        InvokeRepeating("SpawnPowerUp", startDelay, spawnInterval);
    }

    void Update()
    {
    }
    void SpawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int powerupIndex = Random.Range(0, powerupPrefabs.Length);
        Instantiate(powerupPrefabs[powerupIndex], spawnPos, powerupPrefabs[powerupIndex].transform.rotation);
    }
}