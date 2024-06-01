using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunAb : MonoBehaviour
{
     public GameObject[] enemys = null;
  
    void Update()
    {
        enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if(Input.GetKeyDown(KeyCode.Z))
        {
            Roar();
        }
    }

    private void Roar()
    {
        for (int i = 0; i < enemys.Length; i++)
        {

            if(enemys[i].GetComponent<EnemyMovement>() != null)
            {
                enemys[i].GetComponent<EnemyMovement>().stun = true;
            }

            if(enemys[i].GetComponent<EnemyAi>() != null)
            {
                enemys[i].GetComponent<EnemyAi>().stun = true;
            }

            if(enemys[i].GetComponent<TowerEnemyAi>() != null)
            {
                enemys[i].GetComponent<TowerEnemyAi>().stun = true;
            }
        }
    }
}
