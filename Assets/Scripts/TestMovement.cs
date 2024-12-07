using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    public float thrustenergy = 6.0f;
    public float rotationspeed = 240.0f;
    public float maxspeed = 12.0f;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float rotationInput = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * rotationInput * rotationspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 thrust = transform.up * thrustenergy;
            rb.AddForce(thrust);
        }
    }
}