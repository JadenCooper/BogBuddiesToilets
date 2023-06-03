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
    public bool Seen = false;
    [SerializeField]
    private float invisableTimer = 20f; // Time To Turn Off
    [SerializeField]
    private bool isCoroutineRunning = false;

    public Collectible collectible;

    private void Start()
    {
        if(collectible)//making sure the game doesn't break while we finish adding collectibles
        {
            collectible.collected = false;
        }
        text.text = InputText;
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
                if(collectible) //making sure the game doesn't break while we finish adding collectibles
                {
                    collectible.collected = true;
                }
                Seen = true;
                image.color = Color.blue; // Set Image To Blue For Playerfeedback That Text Has Been Seen
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