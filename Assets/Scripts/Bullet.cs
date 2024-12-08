using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Asteroids asteroid = other.GetComponent<Asteroids>();
            if (asteroid != null)
            {
              
            }
        }
    }
}
