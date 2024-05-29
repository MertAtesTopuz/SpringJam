using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 //arda was here

public class EnemyHealth : MonoBehaviour
{

    public int enemyHealth;
    public int enemyMaxHealth = 10;
    public ParticleSystem particle;

    public GameObject moloz;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

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

        anim.SetTrigger("IsDestroyed");

        yield return new WaitForSeconds(2);

        Vector3 spawnPosition = new Vector3(transform.position.x, 3f, transform.position.z);

        Instantiate(moloz, spawnPosition, Quaternion.identity);
        particle.Stop();
        Destroy(gameObject);
    }

        
}
