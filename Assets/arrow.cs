using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            FindAnyObjectByType<Godzillah>().health = FindAnyObjectByType<Godzillah>().health - 5;

            Destroy(gameObject);
        }
    }
}
