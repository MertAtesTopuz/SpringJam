using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSpawner : MonoBehaviour
{

    public ItemsToSpawn itemsToSpawn;
    void Start()
    {
        for(int i = 0; i < itemsToSpawn.numberOfSpawn; i++)
        {
            Instantiate(itemsToSpawn.itemToSpawn, transform.position, Quaternion.identity);
        }
    }

}
