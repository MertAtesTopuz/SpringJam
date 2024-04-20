using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMaker : MonoBehaviour
{

    public GameObject attackArea;
    public float attackCooldown = 2;
    public bool canAttack = true;
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
