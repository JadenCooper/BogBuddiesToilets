using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

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
    public float raycastDistance;


    private bool MenuOpened = true;

    public AudioSource walkingAudio;


    public Joystick movementJoystick;
    public bool mobile = false;
    private void Awake()
    {
        rb = GetComponent<CharacterController>();
        walkingAudio = GetComponent<AudioSource>();
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
        bool isEditor = false;
#if UNITY_EDITOR
        /*
        This piece of code will only run while in the editor. This is because 
        the simulator mode needs to be checked since if we just check our device
        it will always return desktop. Only is important for editor.
        */
        isEditor = true;
        if (UnityEngine.Device.SystemInfo.deviceType == DeviceType.Desktop)
        {
            MovementInput = Movement.action.ReadValue<Vector3>().normalized;
        }
        if(UnityEngine.Device.SystemInfo.deviceType == DeviceType.Handheld)
        {
            MovementInput = new Vector3(movementJoystick.Horizontal, 0, movementJoystick.Vertical);
        }
#endif
        // Will run when the device is desktop.
        //if (SystemInfo.deviceType == DeviceType.Desktop && CanMove && !isEditor)
        //{
            //MovementInput = Movement.action.ReadValue<Vector3>().normalized;
        //}

        //Will run when the device is mobile.
        //if(SystemInfo.deviceType == DeviceType.Handheld && CanMove && !isEditor)
        //{
            MovementInput = new Vector3(movementJoystick.Horizontal, 0, movementJoystick.Vertical);
        //}

        if (MovementInput != Vector3.zero && !clickMove)
        {
            if (!walkingAudio.isPlaying)
            {
                walkingAudio.Play();
            }
            //rb.isKinematic = false;
            Move();
            rb.SimpleMove(transform.TransformDirection(movement * Time.deltaTime)); // Increases Velocity And Changes Direction From Local World
        }
        else
        {
            //rb.isKinematic = true;
            walkingAudio.Stop();
        }
    }

    //private void OnEnable()
    //{
    //    Interact.action.performed += Press;
    //    Pause.action.performed += PausePress;
    //}
    //private void OnDisable()
    //{
    //    Interact.action.performed -= Press;
    //    Pause.action.performed -= PausePress;
    //}

    //private void Press(InputAction.CallbackContext obj)
    //{

    //}

    public void MobilePress(InputAction.CallbackContext context)
    {
        if (context.started && CanMove && (Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began))
        {
            // Interact - Shoots Out Raycast Out At Press/Click Position 

            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            eventDataCurrentPosition.position = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
            Ray ray = Camera.main.ScreenPointToRay(Look.action.ReadValue<Vector2>());
            RaycastHit[] hits = Physics.RaycastAll(ray, raycastDistance);
            foreach (RaycastHit hitinfo in hits)
            {
                if (results.Count == 0 || !results[0].gameObject.CompareTag("Joystick"))
                {
                    RunRayCastHitInteractable(hitinfo);
                }
            }
        }
    }

    public void PCPress(InputAction.CallbackContext context)
    {
        if (context.started && CanMove)
        {
            Ray ray = Camera.main.ScreenPointToRay(Look.action.ReadValue<Vector2>());
            RaycastHit[] hits = Physics.RaycastAll(ray, raycastDistance);
            foreach (RaycastHit hitinfo in hits)
            {
                RunRayCastHitInteractable(hitinfo);
            }
        }
    }

    public void RunRayCastHitInteractable(RaycastHit hitinfo)
    {

        if (hitinfo.collider.CompareTag("Information")) // Text Tag Is For Intractable Doesn't Work On Any Other Tag For Some Reason
        {
            hitinfo.collider.GetComponent<Interactable>().Interact(); // Activates Object's Interaction
        }
        else if (hitinfo.collider.CompareTag("Arrow")) // Text Tag Is For Intractable Doesn't Work On Any Other Tag For Some Reason
        {
            hitinfo.collider.GetComponent<Interactable>().Interact(); // Activates Object's Interaction
        }

    }

    private void PausePress(InputAction.CallbackContext obj)
    {
        Debug.Log("Pause");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
