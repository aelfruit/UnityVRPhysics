using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level0enemyspawner : MonoBehaviour
    using UnityEngine;

{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public int maxEnemies = 10;

    private int enemiesSpawned = 0;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    private void SpawnEnemy()
    {
        if (enemiesSpawned < maxEnemies)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemiesSpawned++;
        }
    }
}
