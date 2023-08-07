using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;
public class Rotation : Interactable
{
    private DateTime lastOpen;
    public bool open;
    public bool Activated = false;
    private bool opening;
    private bool closing;
    private int count;
    public int RotateTimes;

    // Start is called before the first frame update
    void Start()
    {
        open = true;
        opening = false;
        closing = false;
        count = 0;
    }
    // Update is called once per frame
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

    private void Toggle()
    {
        if (open)
        {
            opening = true;
            Debug.Log("Activated = true");
        }
        else
        {
            closing = true;
            Debug.Log("Activated = false");
        }
        open = !open;
        lastOpen = DateTime.Now;
    }

    public override void Interact()
    {
        Activated = true;
    }
}