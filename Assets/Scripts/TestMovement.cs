using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    public float thrustenergy = 3.0f;
    public float rotationspeed = 120.0f;
    public float maxspeed = 12.0f;

    private Rigidbody2D rb;

    public AudioClip engines;
    private AudioSource audiosource;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    [System.Obsolete]
    void Update()
    {
        float rotationInput = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * rotationInput * rotationspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 thrust = transform.up * thrustenergy;
            rb.AddForce(thrust);
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
}