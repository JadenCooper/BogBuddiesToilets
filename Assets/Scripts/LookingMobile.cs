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
        else if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Arrow"))
                {
                    ArrowMovement objectHit = raycastHit.collider.gameObject.transform.GetComponent<ArrowMovement>();
                    transform.SetPositionAndRotation(objectHit.moveTo, Quaternion.Euler(0, objectHit.rotation, 0));
                    objectHit.LocationArrows.SetActive(true);
                    objectHit.gameObject.transform.parent.gameObject.SetActive(false);
                }
            }
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Text"))
                {
                    DisplayText textObj = raycastHit.collider.GetComponent<DisplayText>();
                    Debug.Log(raycastHit.collider.GetComponent<DisplayText>());
                    textObj.text.SetActive(!textObj.text.activeSelf);
                }
            }
        }
    }
}
