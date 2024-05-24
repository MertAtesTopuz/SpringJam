using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsPlayer;
    public float timeBetweenAttacks;
    private bool alreadyAttack;
    public float attackRange;
    public bool playerInAttackRange;
    public GameObject projectile;
    public Transform projectileSpawn;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent =  GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position,attackRange, whatIsPlayer);

        if (!playerInAttackRange)
        {
            ChasePlayer();
        }
        if (playerInAttackRange)
        {
            AttackPlayer();
        }

        transform.rotation = Quaternion.Euler(-90, transform.rotation.y,transform.rotation.z);
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        //transform.LookAt(player);

        if (!alreadyAttack)
        {
            Rigidbody rb = Instantiate(projectile, projectileSpawn.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.right * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            alreadyAttack = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttack = false;
    }
}
