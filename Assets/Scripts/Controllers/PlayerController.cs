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
    public float MaxSpeed = 20;
    public float CurrentSpeed = 0;
    public float Acceleration = 10;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        CalculateSpeed();
        MovementInput *= CurrentSpeed;
        movement = MovementInput;
    }

    public void CalculateSpeed()
    {
        if (MovementInput == Vector3.zero)
        {
            CurrentSpeed += -Acceleration * Time.deltaTime;
        }
        else
        {
            CurrentSpeed += Acceleration * Time.deltaTime;
        }
        CurrentSpeed = Mathf.Clamp(CurrentSpeed, 0, MaxSpeed);
    }

    private void FixedUpdate()
    {
        MovementInput = Movement.action.ReadValue<Vector3>().normalized;
        Debug.Log(MovementInput);
        Move();
        rb.velocity = transform.TransformDirection(movement * Time.deltaTime); // Increases Velocity And Changes Direction From Local World
    }
}
