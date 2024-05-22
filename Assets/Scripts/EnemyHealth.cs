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

        InvokeRepeating("Shake", 0.1f, 0.5f);

        yield return new WaitForSeconds(2);

        Vector3 spawnPosition = new Vector3(transform.position.x, 3f, transform.position.z);

        Instantiate(moloz, spawnPosition, Quaternion.identity);
        particle.Stop();
        Destroy(gameObject);
    }

    private Vector3 Shake()
    {
        
        Debug.Log("Invoked.");

        int isMinus, whichVector, xVal = 0, yVal = 0;

        isMinus = Random.Range(0,2) == 0 ? -1 : 1;
        whichVector = Random.Range(0, 2);

        switch (whichVector)
        {
            case 0:
                yVal = 0;
                xVal = 5;
                break;
            case 1:
                yVal = 5;
                xVal = 0;
                break;
        }

        transform.position = new Vector3(transform.position.x + isMinus * xVal * Time.deltaTime, transform.position.y + isMinus * yVal * Time.deltaTime, transform.position.z);

        return transform.position;
    }
        
}
