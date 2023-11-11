using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject Prefab;
    public List<GameObject> spawnPoints;
    public int spawnCounter;
    public void SpawnObject()
    {
        if(spawnCounter >= spawnPoints.Count)
        {
            spawnCounter = 0;
        }
        Instantiate(Prefab, spawnPoints[spawnCounter].transform);
        spawnCounter++;
    }
}
