using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private DateTime lastOpen;
    private bool open;
    private bool hovering;
    public float positionX;
    public float positionY;
    public float positionZ;
    public float rotationX;
    public float rotationY;
    public float rotationZ;

    // Start is called before the first frame update
    void Start()
    {
        open = true;
        hovering = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.AppButton && hovering)
        {
            if (lastOpen == null)
            {
                Open();
            }
            else if (DateTime.Compare(DateTime.Now, lastOpen.AddMilliseconds(200)) > 0)
            {
                Open();
            }
        }
    }

    private void Open()
    {
        if (open)
        {
            transform.localPosition = new Vector3(positionX, positionY, positionZ);
            transform.eulerAngles = new Vector3(rotationX, rotationY, rotationZ);
        }
        else
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        open = !open;
        lastOpen = DateTime.Now;
    }
    
    public void OnEnter()
    {
        hovering = true;
    }
    public void OnExit()
    {
        hovering = false;
    }
}
