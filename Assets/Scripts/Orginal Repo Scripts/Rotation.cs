using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;
using UnityEngine.Events;

public class Rotation : Interactable
{
    private DateTime lastOpen;
    public bool open = true;
    public bool Activated = false;
    private bool opening = false;
    private bool closing = false;
    private int count = 0;
    public int RotateTimes;
    void Update()
    {
        if (Activated)
        {
            if (lastOpen == null)
            {
                Toggle();
            }
            else if (DateTime.Compare(DateTime.Now, lastOpen.AddMilliseconds(300)) > 0)
            {
                Toggle();
            }
            Activated = false;
        }
        if (opening && !closing)
        {
            if (count >= RotateTimes)
            {
                count = 0;
                opening = false;
            }
            else
            {
                transform.Rotate(Vector3.up, 10f);
                count++;
            }
        }
        if (closing && !opening)
        {
            if (count >= RotateTimes)
            {
                count = 0;
                closing = false;
            }
            else
            {
                transform.Rotate(Vector3.up, -10f);
                count++;
            }
        }
    }

    public virtual void Toggle()
    {
        if (open)
        {
            opening = true;
        }
        else
        {
            closing = true;
        }
        open = !open;
        lastOpen = DateTime.Now;
    }

    public override void Interact()
    {
        Activated = true;
    }
}