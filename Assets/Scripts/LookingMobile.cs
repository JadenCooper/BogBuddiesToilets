using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingMobile : MonoBehaviour
{
    public Transform cameraTransform;
    public float cameraSensitivity;

    private Vector2 lookInput;
    private float cameraPitch;
    public bool CanMove = false;
    // Update is called once per frame
    void Update()
    {
        // Grabs the Touch Input.
        if (CanMove && Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                //The location of where you are moving too.
                lookInput = t.deltaPosition * cameraSensitivity * Time.deltaTime;
                //Makes it so you cannot look into yourself or right upwards.
                cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -90f, 90f);
                //Moves the camera slowly to the location of your finger movement.

                //for left/right
                cameraTransform.localRotation = Quaternion.Euler(cameraPitch, 0, 0);

                transform.Rotate(transform.up, lookInput.x);
            }
            else if (t.phase == TouchPhase.Stationary)
            {
                //If player is not moving their finger, no need to move the camera so its set to 0,0.
                lookInput = Vector2.zero;
            }
            else if (Input.touchCount > 0 && t.phase == TouchPhase.Began && t.phase != TouchPhase.Moved && t.phase == TouchPhase.Stationary)
            {
                //Starts by sending out a raycast to check what object has been hit closest to the player.
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                //for up/down
                transform.Rotate(transform.up, lookInput.x);
            }
            else if (t.phase == TouchPhase.Stationary)
            {
                //If player is not moving their finger, no need to move the camera so its set to 0,0.
                lookInput = Vector2.zero;
            }

            else if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                //Starts by sending out a raycast to check what object has been hit closest to the player.
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                //raycasthit WILL become our gameobject that we interacted with.
                RaycastHit raycastHit;

                //Checks IF you hit something and returns raycasthit WITH a gameobject attached to it.
                if (Physics.Raycast(raycast, out raycastHit))
                {
                    ////Checks if the gameobjects tag is Arrow.
                    //if (raycastHit.collider.CompareTag("Arrow"))
                    //{
                    //    ArrowMovement objectHit = raycastHit.collider.gameObject.transform.GetComponent<ArrowMovement>();
                    //    transform.SetPositionAndRotation(objectHit.moveTo, Quaternion.Euler(0, objectHit.rotation, 0));
                    //    objectHit.LocationArrows.SetActive(true);
                    //    objectHit.gameObject.transform.parent.gameObject.SetActive(false);
                    //}

                    //Checks if the game objects tag is Text
                    if (raycastHit.collider.CompareTag("Text"))
                    {
                        DisplayText textObj = raycastHit.collider.GetComponent<DisplayText>();
                        Debug.Log(raycastHit.collider.GetComponent<DisplayText>());
                        textObj.textHolder.SetActive(!textObj.textHolder.activeSelf);
                    }
                }
            }
        }
    }
}
