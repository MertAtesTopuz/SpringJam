using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    public int enemyMaxHealth = 10;

    void Start()
    {
        enemyHealth = enemyMaxHealth;
    }

    public void EnemyTakeDamage(int enemyDamageTaken)
    {
        enemyHealth -= enemyDamageTaken;

        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
