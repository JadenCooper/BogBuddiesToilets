using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayText : MonoBehaviour
{
    public GameObject canvas;
    private bool hovering;
    private float hoverValue = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.GetComponent<CanvasGroup>().alpha = hoverValue;
        hovering = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hovering && hoverValue < 1.0f)
        {
            hoverValue += 0.05f;
        }
        if (!hovering && hoverValue > 0.0f)
        {
            hoverValue -= 0.05f;
        }
        canvas.GetComponent<CanvasGroup>().alpha = hoverValue;
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
