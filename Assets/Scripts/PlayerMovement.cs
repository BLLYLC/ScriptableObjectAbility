using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody playerRigidbody;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform cameraTransform;
    private Vector2 moveInput;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
        
    }
    public Vector2 GetMoveinput()
    {
        return moveInput;
    }
    public Transform GetCameraTransform()
    {
        return cameraTransform;
    }
    private void HandleMovement()
    {
        moveInput.x = 0; moveInput.y = 0;
        if (Keyboard.current.wKey.isPressed)
        {
            moveInput.x = 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            moveInput.y = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            moveInput.y = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            moveInput.x = -1;
        }
        Vector3 move = cameraTransform.forward * moveInput.x + cameraTransform.right * moveInput.y;
        move.y = 0f;
        move.Normalize();

        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
