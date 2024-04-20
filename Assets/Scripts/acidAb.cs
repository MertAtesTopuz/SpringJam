using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acidAb : MonoBehaviour
{
    public GameObject acidBall;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(acidBall,transform.position,transform.rotation);
        }
    }
}
