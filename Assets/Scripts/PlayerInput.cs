using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    // This script handles all player inputs and sends that information out in events
    public UnityEvent<Vector2> OnPointerInput, OnInteract;
    public UnityEvent OnPause;
    [SerializeField]
    private InputActionReference pointerPosition, interact, pause;
    private void Update()
    {
        // These Actions/Events Give Values
        OnPointerInput?.Invoke(GetPointerPosition());
    }
    private Vector2 GetPointerPosition()
    {
        Vector2 mousePos = pointerPosition.action.ReadValue<Vector2>();
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void OnEnable()
    {
        // These Actions/Events Just Say They Occurred
        interact.action.performed += PerformInteraction;
        pause.action.performed += PreformPause;
    }
    private void OnDisable()
    {
        interact.action.performed -= PerformInteraction;
        pause.action.performed -= PreformPause;
    }

    private void PerformInteraction(InputAction.CallbackContext obj)
    {
        // Sends Out The Raycast To Check For Interaction
        OnInteract?.Invoke(pointerPosition.action.ReadValue<Vector2>());
    }
    private void PreformPause(InputAction.CallbackContext obj)
    {
        // Opens Pause Menu
        OnPause?.Invoke();
    }
}
