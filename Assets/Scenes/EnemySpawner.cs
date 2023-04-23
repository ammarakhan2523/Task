using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner instance;

    public GameObject enemyPrefab;
    public float spawnInterval = 5.0f;
    public int currentEnemyCount;
    private float timeSinceLastSpawn = 0.0f;
    private int enemiesSpawned = 0;
    private EnemySpawner enemySpawner;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();

      
        enemiesSpawned = PlayerPrefs.GetInt("EnemiesSpawned", 0);
        for (int i = 0; i < enemiesSpawned; i++)
        {
            
            Vector3 spawnDirection = new Vector3(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 10.0f), 0.0f);
            Instantiate(enemyPrefab, transform.position, Quaternion.LookRotation(spawnDirection));

        }
    }

    void Update()
    {

        print("before : spawned " + PlayerPrefs.GetInt("EnemiesSpawned", 0));

        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemiesSpawned++;
            print(enemiesSpawned);
            PlayerPrefs.SetInt("EnemiesSpawned", enemiesSpawned);
            timeSinceLastSpawn = 0.0f;
        }

        print("after : spawned " + PlayerPrefs.GetInt("EnemiesSpawned", 0));
    }
}
   