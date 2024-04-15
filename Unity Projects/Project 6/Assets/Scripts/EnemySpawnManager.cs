using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array for UFO's
    public int ufoIndex;
    private float spawnRangeX = 10f;
    private float spawnPosZ = 20f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start(){
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void Update()
    {
    }
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
