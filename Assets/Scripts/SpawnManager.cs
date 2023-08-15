using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private GameObject powerup;

    [SerializeField] private float zEnemySpawn = 12f;
    [SerializeField] private float xSpawnRange = 10f;
    [SerializeField] private float zPowerupRange = 5f;
    [SerializeField] private float ySpawn = 0.75f;

    [SerializeField] private float powerupSpawnTime = 5f;
    [SerializeField] private float enemySpawnTime = 1f;
    [SerializeField] private float startDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(RandomPowerup), startDelay,  powerupSpawnTime);
        InvokeRepeating(nameof(RandomSpawnEnemy), startDelay, enemySpawnTime);
    }

    void RandomSpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void RandomPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
