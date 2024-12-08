using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 4.0f;
    public float spawnDistance = 1.0f;

    private float timeSinceLastSpawn;
    public Transform playerTransform;
    void Start()
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindWithTag("Player").transform;
        }
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0f;
            Spawn();
        }
    }

    void Spawn()
    {
        Vector2 randomDirection = Random.insideUnitCircle;
        Vector2 spawnPosition = (Vector2)(randomDirection * spawnRate * spawnDistance);
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}
