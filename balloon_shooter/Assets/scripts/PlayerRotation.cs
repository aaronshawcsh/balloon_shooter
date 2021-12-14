using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    public float sens;
    private Vector2 mouse;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update() {
        transform.Rotate(-mouse.y * sens * 0.01f, mouse.x * sens * 0.01f, 0);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        mouse = context.ReadValue<Vector2>();
    }
}
