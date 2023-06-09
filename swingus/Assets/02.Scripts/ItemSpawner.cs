using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float spawnInterval = 2f;

    private float timer = 1.0f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnItem();
            timer = spawnInterval;
        }

    }

    void SpawnItem()
    {
        float randomX = Random.Range(-13f, 13f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, randomX);
        Instantiate(ItemPrefab, spawnPosition, Quaternion.identity);
    }
}
