using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public int maxCollectibles = 15;
    public float spawnRangeX = 5.0f;

    public void Start()
    {
        SpawnCollectibles();
    }

    public void SpawnCollectibles()
    {
        for (int i = 0; i < maxCollectibles; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2f, 0f);
            Instantiate(collectiblePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
