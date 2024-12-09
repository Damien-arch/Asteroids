using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TestMovement : MonoBehaviour
{
    public float thrustenergy = 2.0f;
    public float rotationspeed = 50.0f;
    public float maxspeed = 5.0f;

    private Rigidbody2D rb;

    public AudioClip engines; // This is for engine sound
    private AudioSource audioSource;

    public AudioClip wingsSound; // New variable to hold Wings.mp3 audio clip
    private bool isMoving = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No audio found");
        }
        else
        {
            audioSource.loop = true;
        }

        // Load the Wings.mp3 audio clip
        wingsSound = Resources.Load<AudioClip>("Audio/Wings"); // Ensure your Wings.mp3 is located at "Assets/Resources/Audio"
    }

    [System.Obsolete]
    void Update()
    {
        float rotationInput = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * rotationInput * rotationspeed * Time.deltaTime);

        // Check if the player is pressing the W key (moving forward)
        bool isThrusting = Input.GetKey(KeyCode.W);

        if (isThrusting)
        {
            Vector2 thrust = transform.up * thrustenergy;
            rb.AddForce(thrust);
        }

        // Check if the player is moving (by checking the speed)
        if (rb.velocity.magnitude > 0.1f && !isMoving)
        {
            isMoving = true;
            PlayWingsSound();
        }
        else if (rb.velocity.magnitude <= 0.1f && isMoving)
        {
            isMoving = false;
            StopWingsSound();
        }

        if (rb.velocity.magnitude > maxspeed)
        {
            rb.velocity = rb.velocity.normalized * maxspeed;
        }
    }

    [System.Obsolete]
    void FixedUpdate()
    {
        rb.velocity *= 0.99f;
    }

    void PlayWingsSound()
    {
        if (wingsSound != null && !audioSource.isPlaying)
        {
            audioSource.clip = wingsSound;
            audioSource.Play();
        }
    }

    void StopWingsSound()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}