using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dash : MonoBehaviour
{
    [SerializeField] private float dashingPower = 24f; //dashin gücü
    [SerializeField] private float dashingTime = 0.2f; //dash ne kadar sürecek
    [SerializeField] private float dashingCooldown = 1f; //dash attıktan sonra yeniden ne zaman dash atabilicez
    private bool canDash = true; //dash atıp atamayacağımızı denetler
    private bool isDashing; //dash atıyot muyuz onu denetler
    private IEnumerator dashCoroutine; //dash atma coroutinia
    private Rigidbody rb;
    public bool dashOpen;
    private Godzillah movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = GetComponent<Godzillah>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            //Dashing();
        }

       // DashForce();
    }
    public void Dashing()
    {
        if (canDash == true && dashOpen == true)
        {
            if (dashCoroutine != null)
            {
                StopCoroutine(dashCoroutine);
            }

            dashCoroutine = DashCor(dashingTime, dashingCooldown);
            StartCoroutine(dashCoroutine);
        }
    }

    private void DashForce()
    {
        if (isDashing == true)
        {
            //transform.Translate(0, 0, movement.MovePlayer().y * dashingPower);
        }
    }

    private IEnumerator DashCor(float dashTime, float dashCooldown)
    {
        canDash = false;
        isDashing = true;

        rb.useGravity = false;
        rb.velocity = Vector3.zero;

        yield return new WaitForSeconds(dashTime);

        isDashing = false;

        rb.velocity = Vector3.zero;
        rb.useGravity = true;

        yield return new WaitForSeconds(dashCooldown);

        canDash = true;
    }
}
