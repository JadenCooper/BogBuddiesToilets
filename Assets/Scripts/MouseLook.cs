using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public GameObject camera;
    float xrotation = 0;
    float yrotation;
    Vector2 mousemovement;
    float camera_y;
    //Quaternion pos;
    public float mouse_sensitivity = 10f;
    public bool mouseLocked = true;

    void Start()
    {
        mouseLocked = true;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //Update Mouse position to player position
        //pos = Player.transform.rotation;
        ////pos.y += camera_y;
        //transform.rotation = pos;
        //Get mouse movement in new input system
        if (!mouseLocked)
        {
            mousemovement = Mouse.current.delta.ReadValue();     

            xrotation -= mousemovement.y * Time.deltaTime * mouse_sensitivity;   
            xrotation = Mathf.Clamp(xrotation,-20,20);
    
            yrotation += mousemovement.x * Time.deltaTime * mouse_sensitivity;

            //Rotate the camera
            camera.transform.rotation = Quaternion.Euler(xrotation , yrotation , 0);
            gameObject.transform.rotation = Quaternion.Euler(0 , yrotation , 0);
        }
       
    }
    
}
