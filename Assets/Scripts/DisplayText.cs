using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using System;
using UnityEngine.UI;
using TMPro;

public class DisplayText : Interactable
{
    public GameObject Text;
    public String InputText;
    [SerializeField]
    private float invisableTimer = 2f;
    [SerializeField]
    private bool isCoroutineRunning = false;
    private void Start()
    {
        Text.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = InputText;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Debug.Log("Touched");
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");

                if (raycastHit.collider.CompareTag("Text"))
                {
                    Text.SetActive(!Text.activeSelf);
                }
            }

        }
    }

    public void Test()
    {
        Debug.Log("Press");
    }

    public override void Interact()
    {
        Test();
    }
}