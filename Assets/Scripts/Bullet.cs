using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            AsteroidPrefab asteriodComponent = other.GetComponent<AsteroidPrefab>();
            if (asteriodComponent != null)
            {
                asteriodComponent.Split();
            }
        }
    }
}
