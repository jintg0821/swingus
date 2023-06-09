    using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    public GameObject poopPrefab;
    public float spawnInterval = 2f;

    private float timer = 1.0f;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnPoop();
            timer = spawnInterval;
        }

    }

    void SpawnPoop()
    {
        float randomX = Random.Range(-13f, 13f);
        Vector3 spawnPosition = new Vector3(randomX, 6f, randomX);
        Instantiate(poopPrefab, spawnPosition, Quaternion.identity);
    }
}
