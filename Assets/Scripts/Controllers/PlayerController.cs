using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private InputActionReference Movement, Interact, Look, Pause;
    [SerializeField]
    private Vector3 MovementInput;
    private CharacterController rb;
    public Vector3 movement;
    //public float MaxSpeed = 20;
    //public float CurrentSpeed = 0;
    //public float Acceleration = 10;
    public float speed = 700;
    public bool CanMove = false;
    public bool clickMove = false;
    public MouseLook mouseLook;
    public GameObject player;

    public Joystick movementJoystick;
    public bool mobile = false;
    private void Awake()
    {
        rb = GetComponent<CharacterController>();
    }
    public void Move()
    {
        //CalculateSpeed();
        //MovementInput *= CurrentSpeed;
        movement = MovementInput * speed;
        //rb.MovePosition(transform.position + movement * Time.deltaTime * 1);
        
    }

    public void CalculateSpeed()
    {
        //if (MovementInput == Vector3.zero)
        //{
        //    CurrentSpeed += -Acceleration * Time.deltaTime;
        //}
        //else
        //{
        //    CurrentSpeed += Acceleration * Time.deltaTime;
        //}
        //CurrentSpeed = Mathf.Clamp(CurrentSpeed, 0, MaxSpeed);
    }

    private void FixedUpdate()
    {
        if (!mobile && CanMove)
        {
            MovementInput = Movement.action.ReadValue<Vector3>().normalized;
        }
        else if (CanMove)
        {
            MovementInput = new Vector3(movementJoystick.Horizontal, 0, movementJoystick.Vertical);
        }
        
        if (MovementInput != Vector3.zero && !clickMove)
        {
            //rb.isKinematic = false;
            Move();
            rb.SimpleMove(transform.TransformDirection(movement * Time.deltaTime)); // Increases Velocity And Changes Direction From Local World
        }
        else
        {
            //rb.isKinematic = true;
        }
    }

    private void OnEnable()
    {
        Interact.action.performed += Press;
        Pause.action.performed += PausePress;
    }
    private void OnDisable()
    {
        Interact.action.performed -= Press;
        Pause.action.performed -= PausePress;
    }

    private void Press(InputAction.CallbackContext obj)
    {
        // Interact - Shoots Out Raycast Out At Press/Click Position 
        if (CanMove)
        {
            if (Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began)
            {
                Ray raycast = Camera.main.ScreenPointToRay(Look.action.ReadValue<Vector2>());
                if (Physics.Raycast(raycast, out RaycastHit hitinfo, 400f))
                {
                    if (hitinfo.collider.CompareTag("Information")) // Text Tag Is For Intractable Doesn't Work On Any Other Tag For Some Reason
                    {
                        hitinfo.collider.GetComponent<Interactable>().Interact(); // Activates Object's Interaction
                    }
                    if (hitinfo.collider.CompareTag("Arrow")) // Text Tag Is For Intractable Doesn't Work On Any Other Tag For Some Reason
                    {
                        hitinfo.collider.GetComponent<Interactable>().Interact(); // Activates Object's Interaction
                    }
                }
            }
        }
    }

    private void PausePress(InputAction.CallbackContext obj)
    {
        Debug.Log("Pause");
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Stairs")
        {
            //gameObject.transform.position += new Vector3(0,.3f,0);
        }
    }
}
