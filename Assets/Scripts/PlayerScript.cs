using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public GameObject cam;

    #region Movement#
    private PlayerInput playerInput;
    private InputAction moveAction;

    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] float mesafeX;
    [SerializeField] float mesafeY;
    #endregion#


    #region Rotation#

    #endregion#



    private Rigidbody rb;
    private CapsuleCollider coll;

    private void Awake()
    {
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
        MovePlayer();
        RotatePlayer();

        cam.transform.position = new Vector3(transform.position.x - mesafeX, cam.transform.position.y ,cam.transform.position.y - mesafeY);
    }

    private void MovePlayer()
    {
        Debug.Log(moveAction.ReadValue<Vector2>());

        Vector2 direction = moveAction.ReadValue<Vector2>();

        transform.Translate(0 , 0, direction.y * Time.deltaTime * movementSpeed);
    }

    private void RotatePlayer()
    {
        Vector2 rotationInput = moveAction.ReadValue<Vector2>();
        float rotationAmount = rotationInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }

}
