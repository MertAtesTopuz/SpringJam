using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatapultFollow : MonoBehaviour
{
    public GameObject target;
    public Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
        transform.LookAt(player);
    }
}
