using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMaker : MonoBehaviour
{

    public GameObject attackArea;
    public float attackCooldown = 2;
    public bool canAttack = true;
    public bool tentacleRange;
    public bool clawDamage;
    public  int attackPower = 2;

    void Start()
    {
        if(clawDamage == true)
        {
            attackPower *= 2;
        }

        if(tentacleRange == true)
        {
            transform.localScale = new Vector3(2, 1, 1);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(AttackCooldown());
        }
    }

    public IEnumerator AttackCooldown()
    {
        if (canAttack == true)
        {
            canAttack = false;
            attackArea.SetActive(true);
            yield return new WaitForSeconds(attackCooldown); 
            attackArea.SetActive(false);
            canAttack = true;
        } 
    }
}
