using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    // The force applied when jumping
    public float jumpForce = 10f;

    // The Rigidbody2D component of the GameObject
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to this GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply an upward force to make the object jump
            rb.velocity = Vector2.up * jumpForce;
        }
    }


}
