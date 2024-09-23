using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Prefab to spawn
    public GameObject prefab;

    // Spawn interval
    public float spawnInterval = 0.5f;

    // Minimum and maximum Y positions for random spawning
    public float minY = -5f;
    public float maxY = 5f;

    // Lifetime of the spawned prefab before it destroys itself
    public float lifetime = 4f;

    void Start()
    {
        // Start spawning prefabs repeatedly
        InvokeRepeating("SpawnPrefab", 0f, spawnInterval);
    }

    void SpawnPrefab()
    {
        // Generate a random Y position between minY and maxY
        float randomY = Random.Range(minY, maxY);

        // Spawn the prefab at the current X position, random Y position, and default Z position
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        // Instantiate the prefab at the random position
        GameObject spawnedPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);

        // Destroy the prefab after 'lifetime' seconds
        Destroy(spawnedPrefab, lifetime);
    }
}


