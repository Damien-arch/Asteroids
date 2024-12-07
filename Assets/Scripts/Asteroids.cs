using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 4.0f;
    public float spawnDistance = 4.0f;

    void Start()
    {

    }

    void Update()
    {

    }

    void Spawn()
    {
        Vector2 randomDirection = Random.insideUnitCircle;
        Vector2 spawnPosition = (Vector2)(randomDirection * spawnRate * spawnDistance);
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}
