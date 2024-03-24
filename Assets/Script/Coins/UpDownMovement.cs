using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 3f;
    public float upDownDistance = 3f;
    private bool movingUp = true;
    private float targetY;

    void Start()
    {
        
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }

        targetY = transform.position.y + upDownDistance;
    }

    void Update()
    {
        
        if (movingUp)
        {
            if (transform.position.y >= targetY)
            {
                movingUp = false;
            }
        }
        else
        {
            if (transform.position.y <= targetY - upDownDistance)
            {
                movingUp = true;
            }
        }

        
        Vector3 movement = new Vector3(0f, movingUp ? 1f : -1f, 0f).normalized;
        rb.velocity = movement * moveSpeed;
    }
}
