using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayText : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    private bool hovering = false;
    private float hoverValue = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = hoverValue;
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
        canvasGroup.alpha = hoverValue;
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
