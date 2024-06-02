using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KatapultAi : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsPlayer;
    public float timeBetweenAttacks;
    private bool alreadyAttack;
    public float attackRange;
    public bool playerInAttackRange;
    public GameObject projectile;
    public GameObject spawnedProjectile;
    public Transform projectileSpawn;
    public bool stun;
    public float stunTime;
    public float stunTimeSet;
    public Animator anim;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent =  GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        spawnedProjectile = Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation);
        spawnedProjectile.transform.SetParent(projectileSpawn);
    }

    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position,attackRange, whatIsPlayer);

        if (!stun)
        {
            if (!playerInAttackRange)
            {
                ChasePlayer();
            }
            if (playerInAttackRange)
            {
                AttackPlayer();
            }
        }
        else
        {
            stunTime -= Time.deltaTime;
            agent.SetDestination(transform.position);

            if (stunTime < 0)
            {
                stun = false;
                stunTime = stunTimeSet;
            }
        }

        transform.LookAt(player);
        transform.rotation = Quaternion.Euler(0, -90 ,0);
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        

        if (!alreadyAttack)
        {
            anim.SetTrigger("isAttack");
            alreadyAttack = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        if(spawnedProjectile != null)
        {
            Destroy(spawnedProjectile);
        }

        spawnedProjectile = Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation);
        spawnedProjectile.transform.SetParent(projectileSpawn);
        alreadyAttack = false;
    }

    public void Attack()
    {
        Rigidbody rb = spawnedProjectile.GetComponent<Rigidbody>();
        spawnedProjectile.transform.SetParent(null);
        rb.isKinematic =false;
        rb.AddForce(-transform.forward * 32f, ForceMode.Impulse);
        rb.AddForce(transform.up * 8f, ForceMode.Impulse);
    }
}
