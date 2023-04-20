using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pockey_spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 10f;
    public int maxEnemies = 8;

    private float timer;
    private int currentEnemies;

    void Start()
    {
        currentEnemies = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval && currentEnemies < maxEnemies)
        {
            timer = 0f;
            SpawnEnemy();
            currentEnemies++;
        }
    }

    void SpawnEnemy()
    {
        int i = Random.Range(0, 15);
        Vector3 v = new Vector3(i, 0, 2);


        Vector3 spawnPosition = Vector3.zero + v;
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    public void EnemyDestroyed()
    {
        currentEnemies--;
    }
}

