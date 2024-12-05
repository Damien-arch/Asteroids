using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Move Up with 'W'
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * 10.0f;
        }

        // Move Left with 'A'
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * 10.0f;
        }

        // Move Down with 'S'
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * 10.0f;
        }

        // Move Right with 'D'
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * 10.0f;
        }
    }
}