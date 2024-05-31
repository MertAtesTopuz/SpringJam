using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform targetObj;
    private PlayerAwaerness playerAwaerness;
    public GameObject pointer;
    public GameObject projectilePre;
    public float time;
    public float setTime;
    public bool stun;
    public float stunTime;
    public float stunTimeSet;

    void Start()
    {
        playerAwaerness = GetComponent<PlayerAwaerness>();
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (!stun)
        {
            if(playerAwaerness.AwareOfPlayer == false)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetObj.position, 3 * Time.deltaTime);
            }
            else if(playerAwaerness.AwareOfPlayer == true)
            {
                time -= Time.deltaTime;
            }

            if(time <= 0f)
            {
                time = setTime;
                Invoke("Attack", 1f);
            }
            transform.LookAt(targetObj);
        }
        else
        {
            stunTime -= Time.deltaTime;

            if (stunTime < 0)
            {
                stun = false;
                time = setTime;
                stunTime = stunTimeSet;
            }
        }
    }

    private void Attack()
    {
        Instantiate(projectilePre,pointer.transform.position, pointer.transform.rotation);
    }
}
