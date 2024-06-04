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
            if(other.GetComponent<EnemyHealth>() != null)
            {
                other.GetComponent<EnemyHealth>().EnemyTakeDamage(damage);
            }

            if(other.GetComponent<EnemyHealthMain>() != null)
            {
                other.GetComponent<EnemyHealthMain>().EnemyTakeDamage(damage);
            }

            if(other.GetComponent<MainEnemyHealth>() != null)
            {
                other.GetComponent<MainEnemyHealth>().EnemyTakeDamage(damage);
            }
        }
    }
}
