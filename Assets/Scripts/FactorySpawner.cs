using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private float lastSpawn;
    public float spawnInterval = 10f;

    void Start()
    {
        float lastShot = Time.time;
    }
    

    // Update is called once per frame
    void Update()
    {
        if((Time.time - lastSpawn) >= spawnInterval)
        {
            GameObject clone = Instantiate(enemy, transform.position, transform.rotation);
            lastSpawn = Time.time;                
        }
        
    }
}