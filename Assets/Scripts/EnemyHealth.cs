using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 //arda was here

public class EnemyHealth : MonoBehaviour
{
    private int whichMob;

    [SerializeField] public int enemyHealth;
    //public int enemyMaxHealth = 10;
    public ParticleSystem particle;
    [SerializeField] private int reward = 100;

    public GameObject moloz;
    public DNACurrency dna;

    //Building Spawn
    public GameObject koyun, at;
    private GameObject willSpawn;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);

        //enemyHealth = enemyMaxHealth;

        whichMob = Random.Range(0, 3);

        switch (whichMob)
        {
            case 0:
                willSpawn = null;
                break;
            case 1:
                willSpawn = koyun;
                break;
            case 2:
                willSpawn = at;
                break;
        }
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

        dna.currencyAmount += reward;

        anim.SetTrigger("IsDestroyed");

        yield return new WaitForSeconds(2);

        Vector3 spawnPosition = new Vector3(transform.position.x, 3f, transform.position.z);

        Instantiate(moloz, spawnPosition, Quaternion.identity);

        spawnPosition.y += spawnPosition.y + 3;
        
        //Mob Spawn
        if(willSpawn != null)
        {
            Instantiate(willSpawn, spawnPosition, Quaternion.identity);
        }

        particle.Stop();
        Destroy(gameObject);
    }

        
}
