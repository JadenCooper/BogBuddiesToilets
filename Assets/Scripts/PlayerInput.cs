using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    // This script handles all player inputs and sends that information out in events
    public UnityEvent<Vector2> OnMovementInput, OnPointerInput;
    public UnityEvent OnInteract, OnPause;
    [SerializeField]
    private InputActionReference movement, pointerPosition, interact, pause;
    private void Update()
    {
        // These Actions/Events Give Values
        OnMovementInput?.Invoke(movement.action.ReadValue<Vector2>().normalized);
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
        OnInteract?.Invoke();
    }
    private void PreformPause(InputAction.CallbackContext obj)
    {
        OnPause?.Invoke();
    }
}
