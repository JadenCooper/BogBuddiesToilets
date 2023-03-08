using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private InputActionReference Look, Movement;
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
    private Vector2 GetPointerPosition()
    {
        Vector3 mousePos = Look.action.ReadValue<Vector2>();
        return Camera.main.ScreenToWorldPoint(mousePos);
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
        Move();
        rb.velocity = transform.TransformDirection(movement * Time.deltaTime);
    }
}
