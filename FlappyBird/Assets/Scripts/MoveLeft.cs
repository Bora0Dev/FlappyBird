using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
 
    // Speed of movement
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Move the object to the left by subtracting from its x position
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

