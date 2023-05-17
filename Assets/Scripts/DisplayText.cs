using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DisplayText : Interactable
{
    public GameObject textHolder;
    public Image image;
    public TextMeshProUGUI text;
    public String InputText;
    private bool Seen = false;
    public PauseManager pauseManager;
    [SerializeField]
    private float invisableTimer = 20f; // Time To Turn Off
    [SerializeField]
    private bool isCoroutineRunning = false;
    private void Start()
    {
        text.text = InputText;
        pauseManager.IncreaseCount(true);
    }
    public IEnumerator InvisableTimer()
    {
        // Timer To Turn Off
        isCoroutineRunning = true;
        yield return new WaitForSeconds(invisableTimer);
        isCoroutineRunning = false;
        textHolder.SetActive(false);
    }

    public override void Interact()
    {
        // Pressed On 
        if (textHolder.activeSelf)
        {
            // Turn Off Display
            StopCoroutine(InvisableTimer());
            isCoroutineRunning = false;
            textHolder.SetActive(false);
        }
        else
        {
            //Turn On
            //Turn On Display
            textHolder.SetActive(true);
            if (!Seen)
            {
                Seen = true;
                image.color = Color.blue; // Set Image To Blue For Playerfeedback That Text Has Been Seen
                pauseManager.IncreaseCount(false);
            }
            StartCoroutine(InvisableTimer());
        }
    }

    public void OnEnable()
    {
        // Ensure display is off and timer is stopped when enabled
        StopCoroutine(InvisableTimer());
        isCoroutineRunning = false;
        textHolder.SetActive(false);
    }
}