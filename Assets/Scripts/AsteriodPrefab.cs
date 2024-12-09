using UnityEngine;

public class AsteroidPrefab : MonoBehaviour
{
    public float speed = 4.0f;
    public float rotationSpeed = 30.0f;
    public GameObject[] smallerAsteroids;
    public float splitTime = 1.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        rb.linearVelocity = randomDirection * speed;

        transform.Rotate(0f, 0f, Random.Range(0f, 360f));
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    /*
    public void Split()
    {
        if (smallerAsteroids.Length > 0)
        {
            foreach (var asteroidPrefab in smallerAsteroids)
            {
                Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            }
        }

        Destroy(gameObject);
    }
    */
}
