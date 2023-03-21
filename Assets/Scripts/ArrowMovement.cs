using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using System;
using UnityEngine.UI;
using TMPro;

public class ArrowMovement : MonoBehaviour
{
    public Vector3 moveTo;
    public Transform character;
    public string startingText;
    public TextMeshProUGUI text;
    public float rotation;
    public GameObject LocationArrows;

    // Start is called before the first frame update
    void Start()
    {
        text.text = startingText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            RaycastHit raycastHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position), out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Arrow"))
                {
                    ArrowMovement objectHit = raycastHit.collider.gameObject.transform.GetComponent<ArrowMovement>();
                    character.SetPositionAndRotation(objectHit.moveTo, Quaternion.Euler(0, objectHit.rotation, 0));
                    objectHit.LocationArrows.SetActive(true);
                    objectHit.gameObject.transform.parent.gameObject.SetActive(false);
                }
            }
        }
    }
}
