using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform targetObj;
    public PlayerAwaerness playerAwaerness;
    public GameObject pointer;
    public GameObject projectilePre;
    public float time;
    public float setTime;

    void Start()
    {
        playerAwaerness = GetComponent<PlayerAwaerness>();
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if(playerAwaerness.AwareOfPlayer == false)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 3 * Time.deltaTime);
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

    private void Attack()
    {
        Instantiate(projectilePre,pointer.transform.position, pointer.transform.rotation);
    }
}
