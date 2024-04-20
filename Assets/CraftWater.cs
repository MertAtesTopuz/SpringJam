using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CraftWater : MonoBehaviour
{

    public GameObject item;

    private bool burn;

    private void Update()
    {
        burn = FindAnyObjectByType<Hand>().canBurn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item") && burn == true)
        {
            item = other.gameObject;
            Destroy(other.gameObject);
        }
    }
}
