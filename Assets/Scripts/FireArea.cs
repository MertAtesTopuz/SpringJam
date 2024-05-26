using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAreaScript : MonoBehaviour
{
    public AttackMaker attackMaker;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag  == "Enemy")
        {
            other.GetComponent<EnemyHealth>().EnemyTakeDamage(attackMaker.attackPower);
        }
    }
}
