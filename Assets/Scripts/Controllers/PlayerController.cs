using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private InputActionReference Movement;
    [SerializeField]
    private Vector3 MovementInput;
    private Rigidbody rb;
    public Vector3 movement;
    public float Speed = 18;
    public bool CanMove = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        MovementInput *= Speed;
        movement = new Vector3(MovementInput.x, 0, MovementInput.y);
    }


    private void FixedUpdate()
    {
        MovementInput = Movement.action.ReadValue<Vector2>().normalized;
        Move();
        rb.velocity = transform.TransformDirection(movement); // Increases Velocity And Changes Direction From Local World
    }

    public void Press(Vector2 InteractedLocation)
    {
        // Interact - Shoots Out Raycast Out At Press/Click Position 
        if (CanMove)
        {
            Ray raycast = Camera.main.ScreenPointToRay(InteractedLocation);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if ((raycastHit.collider.CompareTag("Arrow") || raycastHit.collider.CompareTag("Text"))) // Text Tag Is For Intractable Doesn't Work On Any Other Tag For Some Reason
                {
                    raycastHit.collider.GetComponent<Interactable>().Interact(); // Activates Object's Interaction
                }
            }
        }
    }
}
