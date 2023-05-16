using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetPosition;
    public float speed = 2.5f;
    private int current_location = 0;

    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition.position, speed * Time.deltaTime);

            if (transform.position == targetPosition.position)
            {
                isMoving = false;
            }
        }
    }

    public void setTarget(Transform targetPosition)
    { 
        this.targetPosition = targetPosition;
        isMoving = true;
    }
    public int getCurrentLocation() { return current_location; }
}
