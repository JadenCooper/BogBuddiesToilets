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
    private float invisableTimer = 20f; // Time To Turn Off
    [SerializeField]
    private bool isCoroutineRunning = false;
    private void Start()
    {
        Text.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = InputText;
    }

    public override void Interact()
    {
        // Pressed On 
        if (Text.activeSelf)
        {
            // Turn Off Display
            StopCoroutine(InvisableTimer());
            isCoroutineRunning = false;
            Text.SetActive(false);
        }
        else
        {
            //Turn On Display
            Text.SetActive(true);
            StartCoroutine(InvisableTimer());
        }
    }
    public IEnumerator InvisableTimer()
    {
        // Timer To Turn Off
        isCoroutineRunning = true;
        yield return new WaitForSeconds(invisableTimer);
        isCoroutineRunning = false;
        Text.SetActive(false);
    }
}