using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttack : MonoBehaviour
{
    public int damage;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag  == "Enemy" || other.tag == "Building")
        {
            other.GetComponent<EnemyHealth>().EnemyTakeDamage(damage);
            other.GetComponent<EnemyHealthMain>().EnemyTakeDamage(damage);
            other.GetComponent<MainEnemyHealth>().EnemyTakeDamage(damage);
        }
    }
}
