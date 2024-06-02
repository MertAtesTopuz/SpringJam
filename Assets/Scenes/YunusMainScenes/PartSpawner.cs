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
            Invoke(nameof(PartSpawn), 0.1f);
        }
        
    }

    public void PartSpawn()
    {   
        Instantiate(itemsToSpawn.itemToSpawn, transform.position, Quaternion.identity);
    }

}
