using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private CharacterController characterController;
    private Vector3 moveDirection;
    private bool isGrounded;
    private bool isOnLadder;
    private bool nearLadder;
    private Vector3 startPosition;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        startPosition = transform.position;
    }

    void Update()
    {
        isGrounded = characterController.isGrounded;

        if (nearLadder && Input.GetKeyDown(KeyCode.E))
        {
            isOnLadder = !isOnLadder;
            moveDirection = Vector3.zero;
            if (isOnLadder)
            {
                characterController.slopeLimit = 90f;
            }
            else
            {
                characterController.slopeLimit = 45f;
            }
        }

        float moveZ = -Input.GetAxis("Horizontal");

        if (isOnLadder)
        {
            float moveY = Input.GetAxis("Vertical") * moveSpeed;
            moveDirection = new Vector3(0, moveY, 0);
        }
        else
        {
            moveDirection = new Vector3(0, moveDirection.y, moveZ * moveSpeed);

            if (isGrounded && Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
            else if (!isGrounded)
            {
                moveDirection.y += Physics.gravity.y * Time.deltaTime;
            }
        }

        characterController.Move(moveDirection * Time.deltaTime);

        if (!isOnLadder && moveZ != 0)
        {
            transform.rotation = Quaternion.Euler(0f, moveZ > 0 ? -90f : 90f, 0f);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            transform.position = startPosition;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            nearLadder = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            nearLadder = false;
            isOnLadder = false;
            characterController.slopeLimit = 45f;
        }
    }
}