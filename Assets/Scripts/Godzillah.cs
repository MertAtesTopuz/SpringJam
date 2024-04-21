using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Godzillah : MonoBehaviour
{
    public GameObject cam;

    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float mesafeX;
    [SerializeField] float mesafeY;

    private Animator anim;
    private Rigidbody rb;
    private CapsuleCollider coll;

    private void Awake()
    {
       // anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {;
        Animation();

        cam.transform.position = new Vector3(transform.position.x - mesafeX, cam.transform.position.y ,cam.transform.position.y - mesafeY);
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        transform.Translate(0 , 0, direction.y * Time.deltaTime * movementSpeed);
        Vector2 rotationInput = context.ReadValue<Vector2>();
        float rotationAmount = rotationInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }


    public void Animation()
    {
       // anim.SetBool("isWalking", Input.GetKey(KeyCode.W));
    }
}
