using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private PlayerControls controls;
    private Vector2 move;
    private Rigidbody2D rb;

    public float speed = 5f;

    void Awake()
    {
        controls = new PlayerControls();

        controls.player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();

        controls.player.Move.canceled += ctx => move = Vector2.zero;
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
}