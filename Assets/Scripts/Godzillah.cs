using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Godzillah : MonoBehaviour
{
    //public GameObject cam;

    #region Movement#
    private PlayerInput playerInput;
    private InputAction moveAction;

    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float mesafeX;
    [SerializeField] float mesafeY;

    private bool isCarrying;
    #endregion#


    #region Rotation#


    #endregion#


    private Animator anim;
    private Rigidbody rb;
    private CapsuleCollider coll;

    private Vector2 dir;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<CapsuleCollider>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }

    void Update()
    {
        dir = MovePlayer();
        RotatePlayer();

        Animation();

        //cam.transform.position = new Vector3(transform.position.x - mesafeX, cam.transform.position.y, cam.transform.position.y - mesafeY);
    }

    public Vector2 MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();

        transform.Translate(0, 0, direction.y * Time.deltaTime * movementSpeed);

        return direction;
    }

    private void RotatePlayer()
    {
        Vector2 rotationInput = moveAction.ReadValue<Vector2>();
        float rotationAmount = rotationInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }

    public void Animation()
    {
        //Empty
    }
}
