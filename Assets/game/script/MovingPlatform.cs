using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed; // Speed of the platform
    public float distance = 7f; // Distance the platform will move
    float minSpeed = 1.5f;
    float maxSpeed = 2.5f;
    private Vector2 startPosition;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        // Move the platform horizontally back and forth
        float fast = Time.time * speed;
        float newPosition = Mathf.PingPong(fast, distance) + startPosition.x;
        transform.position = new Vector2( newPosition, transform.position.y);
    }
}