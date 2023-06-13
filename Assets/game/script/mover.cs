using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] Vector3 velocity;
    float speed = 5;
    void FixedUpdate()
    {
        transform.position += velocity * Time.deltaTime * speed;
    }
    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
