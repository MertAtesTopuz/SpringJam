using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform targetObj;
    public PlayerAwaerness playerAwaerness;

    void Start()
    {
        playerAwaerness = GetComponent<PlayerAwaerness>();
    }

    void Update()
    {
        if(playerAwaerness.AwareOfPlayer == false)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 3 * Time.deltaTime);
        }
    }
}
