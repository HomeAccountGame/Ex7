using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject ballPrefab; // Ball prefab to be instantiated
    public float ballSpeed = 10.0f; // Speed of the ball

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the fire button (left mouse button)
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate a new ball game object
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

            // Get the rigidbody component of the ball game object
            Rigidbody2D ballRigidbody = ball.GetComponent<Rigidbody2D>();

            // Calculate the direction of the ball towards the mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePosition - transform.position).normalized;

            float ballSpeed = 10f;
            int turbo = 3; // the ball was too slow

            // Set the velocity of the ball to the direction and speed
            //ballRigidbody.velocity = direction * ballSpeed * turbo;
            ballRigidbody.AddForce(Vector2.up * ballSpeed*turbo*10, ForceMode2D.Impulse);

        }
    }

    
   
}