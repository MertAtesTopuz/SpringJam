using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerEnemyAi : MonoBehaviour
{
    public Transform player;
    public LayerMask whatIsPlayer;
    public float timeBetweenAttacks;
    private bool alreadyAttack;
    public float attackRange;
    public bool playerInAttackRange;
    public GameObject projectile;
    public Transform projectileSpawn;
    public bool stun;
    public float stunTime;
    public float stunTimeSet;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        stunTime = stunTimeSet;
    }

    void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position,attackRange, whatIsPlayer);
        
        if(!stun)
        {
            if (playerInAttackRange)
            {
                AttackPlayer();
            }
            else
            {
                return;
            }
        }
        else
        {
            stunTime -= Time.deltaTime;

            if (stunTime < 0)
            {
                stun = false;
                stunTime = stunTimeSet;
            }
        }

        transform.rotation = Quaternion.Euler(-90, transform.rotation.y,transform.rotation.z);
    }

    private void AttackPlayer()
    {
        transform.LookAt(player);

        if (!alreadyAttack)
        {
            Rigidbody rb = Instantiate(projectile, projectileSpawn.position, projectileSpawn.rotation).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
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
