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
        CrosshairObject.transform.position = Input.mousePosition;
    }
}
