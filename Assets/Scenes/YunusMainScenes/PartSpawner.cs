using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSpawner : MonoBehaviour
{

    public ItemsToSpawn itemsToSpawn;
    public GameObject itemHolder;
    void Start()
    {
        if(itemsToSpawn.isBought == true)
        {
            itemHolder.SetActive(true);
        } 
    }
}
