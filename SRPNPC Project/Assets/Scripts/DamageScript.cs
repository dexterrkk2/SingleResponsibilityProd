using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] private int damage;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Damage");
        NPC target = collision.collider.GetComponent<NPC>();
        if(target!= null)
        {
            target.TakeDamage(damage);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Damage");
        NPC target = collision.collider.GetComponent<NPC>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }
}
