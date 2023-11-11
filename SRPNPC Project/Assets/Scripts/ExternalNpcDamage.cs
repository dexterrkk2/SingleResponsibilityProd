using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalNpcDamage : MonoBehaviour
{
    public List<NPC> npcs;
    public int damage;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for (int i = 0; i < npcs.Count; i++)
            {
                if (npcs[i] != null)
                {
                    npcs[i].TakeDamage(damage);
                }
            }
        }
    }
}
