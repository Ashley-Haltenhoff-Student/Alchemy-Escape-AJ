using UnityEngine;

public class InputHandler : MonoBehaviour
{

    FirstPersonCamera firstPersonCamera;
    CharacterMovement characterMovement;
    PlayerInteractions playerInteractions;

    void Start()
    {
        firstPersonCamera = GetComponent<FirstPersonCamera>();
        characterMovement = GetComponent<CharacterMovement>();
        playerInteractions = GetComponent<PlayerInteractions>();
    }

    void Update()
    {
        HandleCameraInput();
        HandleMovementInput();
        HandleInteractionInput();
    }

    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    void HandleMovementInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        characterMovement.AddMoveInput(forwardInput, rightInput);
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerInteractions.TryInteract();
        }
    }
}
