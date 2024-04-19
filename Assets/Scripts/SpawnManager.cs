using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-9, 9);
        float posY = 0.6f;
        float spawnPosZ = Random.Range(-9, 9);
        Vector3 randomSpawnPos = new Vector3(spawnPosX, posY, spawnPosZ);
        return randomSpawnPos;
    }
}
