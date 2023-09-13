using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject objectToDestroy;
    public MouseLook mouseLook;

    public Button clickMovementButton;
    public bool clickMove = false;

    public Button freeMovementButton;
    public bool freeMove = false;

    public PlayerController playerController;
    public GameObject arrowsParent;
    public GameObject displays;

    private void Start()
    {
        clickMovementButton.onClick.AddListener(ToggleClickMovement);
        freeMovementButton.onClick.AddListener(ToggleFreeMovement);
    }

    public void DestroyObject()
    {
        if (freeMove || clickMove)
        {
            mouseLook.mouseLocked = false;
            if (clickMove)
            {
                playerController.clickMove = true;
            }
            else
            {
                EnableFreeMovement();
            }
            Destroy(objectToDestroy);
        }
    }

    public void Update()
    {
        if (!clickMove && !freeMove)
        {
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = true;
        }
    }

    private void EnableFreeMovement()
    {
        arrowsParent.SetActive(false);
       displays.SetActive(true);
    }

    public void ToggleFreeMovement()
    {
        freeMove = true;
        clickMove = false;

        freeMovementButton.gameObject.GetComponent<Image>().color = Color.green;
        clickMovementButton.gameObject.GetComponent<Image>().color = Color.red;
    }

    public void ToggleClickMovement()
    {
        freeMove = false;
        clickMove = true;

        freeMovementButton.gameObject.GetComponent<Image>().color = Color.red;
        clickMovementButton.gameObject.GetComponent<Image>().color = Color.green;
    }
}
