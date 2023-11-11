using System;
using UnityEngine;
public class NPC : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float turnSpeed = 90f;
    public void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }
    public void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }
}