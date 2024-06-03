using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class At : MonoBehaviour
{
    public DNACurrency dna;

    [SerializeField] private int health = 6;
    [SerializeField] private int reward = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            health -= FindAnyObjectByType<AttackMaker>().attackPower;
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            dna.currencyAmount += reward;

            Destroy(gameObject);
        }
    }
}
