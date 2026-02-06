using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    public InputSystem_Actions inputActions;
    [SerializeField]
    float speed = 3f;
    Vector2 move;
    Rigidbody2D rb;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }
    void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Move.performed += OnMovement;

        inputActions.Player.Move.canceled += OnMovement;
    }
    void OnDisable()
    {
        inputActions.Player.Disable();
        inputActions.Player.Move.performed -= OnMovement;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMovement(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<Vector2>();

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
}
