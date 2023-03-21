using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingMobile : MonoBehaviour
{
    public Transform cameraTransform;
    public float cameraSensitivity;

    private Vector2 lookInput;
    private float cameraPitch;

    // Update is called once per frame
    void Update()
    {
        Touch t = Input.GetTouch(0);
        if (t.phase == TouchPhase.Moved)
        {
            lookInput = t.deltaPosition * cameraSensitivity * Time.deltaTime;
            cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -90f, 90f);
            cameraTransform.localRotation = Quaternion.Euler(cameraPitch, 0, 0);
            transform.Rotate(transform.up, lookInput.x);
        }
        else if (t.phase == TouchPhase.Stationary)
        {
            lookInput = Vector2.zero;
        }
    }
}
