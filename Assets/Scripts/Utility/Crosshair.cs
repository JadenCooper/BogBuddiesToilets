using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    private GameObject CrosshairObject;
    private void Start()
    {
        CrosshairObject = gameObject;
    }
    private void Update()
    {
        // Makes Sure Crosshair Is Exactly Where The Mouse Is
        CrosshairObject.transform.position = Input.mousePosition;
    }
}
