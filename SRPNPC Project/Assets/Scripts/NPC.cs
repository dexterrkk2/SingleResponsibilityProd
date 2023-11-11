using System;
using UnityEngine;
public class NPC : MonoBehaviour
{
   
    public void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }
}