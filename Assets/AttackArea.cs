using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{

    public int attackPower = 4;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag  == "Enemy")
        {
            other.GetComponent<EnemyHealth>().EnemyTakeDamage(attackPower);
        }
    }
}
