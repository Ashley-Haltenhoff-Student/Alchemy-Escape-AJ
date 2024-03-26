using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController characterController;

    public float moveSpeed = 5.0f;
    private Vector3 moveDirection;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveDirection.Normalize();
        moveDirection.y = -1f;

        characterController.Move(moveSpeed * Time.deltaTime * moveDirection);
    }

    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        moveDirection = (forwardInput * forward) + (rightInput * right);
    }
}
