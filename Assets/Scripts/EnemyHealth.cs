using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int enemyHealth;
    public int enemyMaxHealth = 10;

    public GameObject moloz;

    void Start()
    {
        enemyHealth = enemyMaxHealth;
    }

    public void EnemyTakeDamage(int enemyDamageTaken)
    {
        enemyHealth -= enemyDamageTaken;

        if(enemyHealth <= 0)
        {

            //particle 

            StartCoroutine(Bekle());

        }
    }

    IEnumerator Bekle()
    {

        yield return new WaitForSeconds(2);
        Instantiate(moloz, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
        
}
