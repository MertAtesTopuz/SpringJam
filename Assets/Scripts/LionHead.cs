using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionHead : MonoBehaviour
{
    public GameObject[] enemys = null;
    public List<EnemyMovement> enemyMovements = new List<EnemyMovement>();
    public List<EnemyAi> enemyAis = new List<EnemyAi>();
    public List<TowerEnemyAi> towerEnemyAis = new List<TowerEnemyAi>();
    public int mainCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemys = GameObject.FindGameObjectsWithTag("Enemy");
        if(Input.GetMouseButtonDown(1))
        {
            Roar();
        }
    }

    private void Roar()
    {
        for (int i = 0; i < enemys.Length; i++)
        {
            if(enemys[i] == null)
            {
                return;
            }

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

        /*
        if (enemyMovements.Count > enemyAis.Count && enemyMovements.Count > towerEnemyAis.Count)
        {
            mainCount = enemyMovements.Count;
        }
        else if (enemyAis.Count > enemyMovements.Count && enemyAis.Count > towerEnemyAis.Count)
        {
            mainCount = enemyAis.Count;
        }
        else if (towerEnemyAis.Count > enemyMovements.Count && towerEnemyAis.Count > enemyAis.Count)
        {
            mainCount = towerEnemyAis.Count;
        }
        else
        {
            mainCount = enemyMovements.Count;
        }
        */