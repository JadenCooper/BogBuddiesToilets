using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public GameObject camera;
    float xrotation = 0;
    public float yrotation;
    Vector2 mousemovement;
    float camera_y;
    //Quaternion pos;
    public float mouse_sensitivity = 10f;
    public bool mouseLocked = true;

    public Joystick rotationJoystick;
    public bool mobile = false;
    public float mobileLookSpeed = 2.5f;

    public GameObject joystick1;
    public GameObject joystick2;

    private float xMin = -45, xMax = 45;

    void Start()
    {
        mouseLocked = true;
    }

    public void CheckDeviceTypeOnGameStart()
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
            //joystick1.SetActive(false);
            //joystick2.SetActive(false);
            //Cursor.lockState = CursorLockMode.Locked;
        }
#endif
        // Checks if the device is desktop. If true, disables joystick controls
        // and locks the mouse to the screen.
        if (SystemInfo.deviceType == DeviceType.Desktop && !isEditor)
        {
            //joystick1.SetActive(false);
            //joystick2.SetActive(false);
            //Cursor.lockState = CursorLockMode.Locked;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Update Mouse position to player position
        //pos = Player.transform.rotation;
        ////pos.y += camera_y;
        //transform.rotation = pos;
        //Get mouse movement in new input system


        bool isEditor = false;
#if UNITY_EDITOR
        /*
        This piece of code will only run while in the editor. This is because 
        the simulator mode needs to be checked since if we just check our device
        it will always return desktop. Only is important for editor.
        */
        isEditor = true;
        if (UnityEngine.Device.SystemInfo.deviceType == DeviceType.Desktop && !mouseLocked)
        {
            mousemovement = Mouse.current.delta.ReadValue();
        }
        if (UnityEngine.Device.SystemInfo.deviceType == DeviceType.Handheld && !mouseLocked)
        {
            mousemovement = rotationJoystick.Direction * mobileLookSpeed;
        }
#endif

        //Runs when device is desktop
        if (SystemInfo.deviceType == DeviceType.Desktop && !mouseLocked && !isEditor)
        {
            mousemovement = Mouse.current.delta.ReadValue();
        }
        //Runs when device is mobile
        if (SystemInfo.deviceType == DeviceType.Handheld && !mouseLocked && !isEditor)
        {
            mousemovement = rotationJoystick.Direction * mobileLookSpeed;
        }


        xrotation -= mousemovement.y * Time.deltaTime * mouse_sensitivity;
        xrotation = Mathf.Clamp(xrotation, xMin, xMax);

        yrotation += mousemovement.x * Time.deltaTime * mouse_sensitivity;

        //Rotate the camera
        camera.transform.rotation = Quaternion.Euler(xrotation, yrotation, 0);
        gameObject.transform.rotation = Quaternion.Euler(0, yrotation, 0);

    }

}
