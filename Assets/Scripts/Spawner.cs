using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    private float mainTime;
    public float spawnTime;

    void Start()
    {
        mainTime = spawnTime;
    }

    void Update()
    {
        mainTime -= Time.deltaTime;

        if(mainTime <=0)
        {
            Spawn();
            mainTime = spawnTime;
        }
    }

    public void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
