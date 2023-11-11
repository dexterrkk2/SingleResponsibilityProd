using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMovementScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float turnSpeed = 90f;
    [SerializeField] private float xLimit = 22f;
    [SerializeField] private float zLimit = 22f;
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        if(transform.position.x > xLimit || transform.position.x < -xLimit) 
        {
            moveSpeed = -moveSpeed;
        }
        if (transform.position.z > zLimit || transform.position.z < -zLimit)
        {
            moveSpeed = -moveSpeed;
        }
    }
}
