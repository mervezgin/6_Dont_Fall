using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //PlayerController playerController;

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject powerUpPrefab;

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        //playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //InvokeRepeating("SpawnPowerUpWave", 2, 6);
        SpawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUpPrefab, GenerateSpawnPos(), powerUpPrefab.transform.rotation);
        }
    }

    Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-9, 9);
        float posY = 0.6f;
        float spawnPosZ = Random.Range(-9, 9);
        Vector3 randomSpawnPos = new Vector3(spawnPosX, posY, spawnPosZ);
        return randomSpawnPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    /*void SpawnPowerUpWave()
    {
        if (playerController.hasPowerUp == false)
        {
            Instantiate(powerUpPrefab, GenerateSpawnPos(), powerUpPrefab.transform.rotation);
        }
      
    }*/
}
