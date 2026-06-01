using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    private BoxCollider2D myFeetCollider;

    [SerializeField] private float runSpeed = 10f;
    [SerializeField] private float jumpSpeed = 12f;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myFeetCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Run();
        FlipSprite();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value)
    {
        Debug.Log("Jump input reçu");
        Debug.Log("Touche le sol : " + isTouchingTheGround());

        if (isTouchingTheGround() && value.isPressed)
        {
            Debug.Log("Jump autorisé");
            myRigidbody2D.linearVelocity += new Vector2(0f, jumpSpeed);
        }
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(
            moveInput.x * runSpeed,
            myRigidbody2D.linearVelocity.y
        );

        myRigidbody2D.linearVelocity = playerVelocity;

        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody2D.linearVelocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }

    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody2D.linearVelocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(myRigidbody2D.linearVelocity.x),
                1f,
                1f
            );
        }
    }

    bool isTouchingTheGround()
    {
        return myFeetCollider.IsTouchingLayers(LayerMask.GetMask("Platforms"));
    }
}