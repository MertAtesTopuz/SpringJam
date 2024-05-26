using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemsToSpawn")]
public class ItemsToSpawn : ScriptableObject
{
    public float numberOfSpawn = 0;

    public GameObject itemToSpawn;

    public GameObject locationToSpawn;
}
