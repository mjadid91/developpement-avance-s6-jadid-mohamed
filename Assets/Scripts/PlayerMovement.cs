using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D myRigidbody2D;

    [SerializeField] private float runSpeed = 10f;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(
            moveInput.x * runSpeed,
            myRigidbody2D.linearVelocity.y
        );

        myRigidbody2D.linearVelocity = playerVelocity;
    }
}