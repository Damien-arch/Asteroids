using UnityEngine;

public class ShipController : MonoBehaviour
{
    public int health = 100;
    public GameObject explosionEffect;
    public AudioClip destructionSound;
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to the ship
        audioSource = GetComponent<AudioSource>();
    }

    // Method to apply damage to the ship
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            DestroyShip();
        }
    }

    // Method to destroy the ship
    void DestroyShip()
    {
        // Instantiate explosion effect at the ship's position and rotation
        Instantiate(explosionEffect, transform.position, transform.rotation);

        // Play the destruction sound
        if (destructionSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(destructionSound);
        }

        // Destroy the ship game object
        Destroy(gameObject, destructionSound.length); // Optional: Delays destruction to let sound play
    }

    // Example method to simulate receiving damage
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(25);
        }
    }
}
