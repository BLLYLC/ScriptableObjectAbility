using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 0.1f;
    private float yaw = 0f; // Yatay dönüþ
    private float pitch = 0f; // Dikey dönüþ
    private float rotationY = 0f;

    private void Start()
    {
      
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
        
    private void LateUpdate()
    {
        // --- Fare ile bakýþ ---
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();
        yaw += mouseDelta.x * mouseSensitivity;
        pitch -= mouseDelta.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -80f, 80f); // Yukarý-aþaðý sýnýrlama
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        rotationY=transform.rotation.y;
    }
    public float GetRotationY()
    {
        return rotationY;
    }
}
