using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TpsMovement : MonoBehaviour
{
    public float speed;
    private PlayerInput playerInput;
    private InputAction moveAction;
    public float turnSmoothTime;
    private float turnSmoothVelocity;
    private Animator anim;
    public Transform cam;

    Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 direction = MovePlayer();

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.velocity = moveDir.normalized * speed * Time.deltaTime;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    public Vector3 MovePlayer()
    {
        Vector3 direction = new Vector3(moveAction.ReadValue<Vector2>().x, 0, moveAction.ReadValue<Vector2>().y).normalized;
        
        if(direction != Vector3.zero)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        return direction;
    }
}
