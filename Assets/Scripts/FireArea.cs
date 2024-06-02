using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAreaScript : MonoBehaviour
{
    public int damage;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag  == "Enemy")
        {
            other.GetComponent<EnemyHealth>().EnemyTakeDamage(damage);
        }
    }
}
