using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int enemyHealth;
    public int enemyMaxHealth = 10;
    public ParticleSystem particle;

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
        particle.Play();

        yield return new WaitForSeconds(2);

        Vector3 spawnPosition = new Vector3(transform.position.x, 1.45f, transform.position.z);

        Instantiate(moloz, spawnPosition, Quaternion.identity);
        particle.Stop();
        Destroy(gameObject);
    }
        
}
