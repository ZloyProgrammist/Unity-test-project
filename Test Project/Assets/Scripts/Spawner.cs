using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnTime;
    public float startSpawnTime;
    void Start()
    {
        InvokeRepeating("Spawning",startSpawnTime, spawnTime);
    }

  
    private void Spawning()
    {
        GameObject block = Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation) as GameObject;

    }
}
