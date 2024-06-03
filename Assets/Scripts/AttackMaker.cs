using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackMaker : MonoBehaviour
{

    public GameObject attackArea;
    public float attackCooldown = 2;
    public bool canAttack = true;
    public bool tentacleRange;
    public bool clawDamage;
    public  int attackPower = 2;
    private PartHolder parts;

    public ParticleSystem fireParticle;
    public GameObject fireArea;
    private Animator anim;
    public Animator clawAnim;
    public Animator octopusAnim;

    void Start()
    {
        parts = GetComponent<PartHolder>();
        
        if(parts.hand != null)
        {

            switch (parts.hand.GetType().ToString())
            {
                case "Claw":
                    anim = clawAnim;
                    break;

                case "Tentacle":
                    anim = octopusAnim;
                    break;
            }
        }

        if(clawDamage == true)
        {
            attackPower *= 2;
        }

        if(tentacleRange == true)
        {
            transform.localScale = new Vector3(2, 1, 1);
        }
    }

    public void BaseAttack(InputAction.CallbackContext context)
    {
        StartCoroutine(AttackCooldown());
    }

    public void Ability(InputAction.CallbackContext context)
    {
        StartCoroutine(FireAttack());
    }

    public IEnumerator AttackCooldown()
    {
        if (canAttack == true)
        {
            anim.SetTrigger("isAttack");
            canAttack = false;
            attackArea.SetActive(true);
            yield return new WaitForSeconds(attackCooldown); 
            attackArea.SetActive(false);
            canAttack = true;
        } 
    }

    private IEnumerator FireAttack()
    {
        fireParticle.Play();
        fireArea.SetActive(true);
        yield return new WaitForSeconds(2);
        fireParticle.Stop();
        yield return new WaitForSeconds(1);
        fireArea.SetActive(false);
    }
}
