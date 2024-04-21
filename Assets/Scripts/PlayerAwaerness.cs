using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAwaerness : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    public LayerMask  whatIsPlayer;
    public GameObject projectile;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    public float attackCD;
    bool canAttack;

    void Awake()
    {
        player = FindObjectOfType<AttackMaker>().transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if(playerInSightRange && playerInAttackRange) Chasing();
        if(playerInSightRange && playerInAttackRange) Attack();
    }

    void Chasing()
    {
        agent.SetDestination(player.position);
    }

    void Attack()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if(!canAttack)
        {

            Rigidbody rb= Instantiate(projectile, transform.position, quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);

            canAttack = false;
            Invoke(nameof(ResetAttack), attackCD);
        }
    }

    void ResetAttack()
    {
        canAttack = false;
    }
}
