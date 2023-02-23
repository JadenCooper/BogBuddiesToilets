using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;

public class Lights : MonoBehaviour
{
    private bool on;
    private DateTime lastOpen;
    private bool hovering;
    public GameObject LightsObject;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.AppButton && hovering)
        {
            if (lastOpen == null)
            {
                Toggle();
            }
            else if (DateTime.Compare(DateTime.Now, lastOpen.AddMilliseconds(300)) > 0)
            {
                Toggle();
            }
        }
    }
    private void Toggle()
    {
        on = !on;
        LightsObject.SetActive(on);
        lastOpen = DateTime.Now;
    }
    public void OnEnter()
    {
        hovering = true;
        GameObject.Find("GvrControllerPointer").GetComponent<GvrArmModel>().OnHover();
    }
    public void OnExit()
    {
        hovering = false;
        GameObject.Find("GvrControllerPointer").GetComponent<GvrArmModel>().OnExit();
    }
}
