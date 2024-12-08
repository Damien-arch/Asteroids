using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;
    public float bulletSpeed = 10f;
    public AudioClip shootSound;
    private AudioSource shootingAudioSource;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = launchPoint.up * bulletSpeed;
        }
    }
}
