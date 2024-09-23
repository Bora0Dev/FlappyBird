using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an object tagged "Barrel"
        if (collision.gameObject.CompareTag("barrel"))
        {
            // Destroy the player GameObject
            Destroy(gameObject);
        }
    }
}

