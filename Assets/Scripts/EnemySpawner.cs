using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    [SerializeField] GameObject enemyPrefab;
    float spawnRate = 3f;
    void Update()
    {
        spawnRate -= Time.deltaTime;
        if (spawnRate < 0)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);

            spawnRate = 3f;
        }




    }


}
