using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DisplayText : Interactable
{
    public GameObject textHolder;
    public bool isImage;
    public Image image;
    public TextMeshProUGUI text;
    public String InputText;
    public bool Seen = false;
    [SerializeField]
    private float invisableTimer = 20f; // Time To Turn Off
    [SerializeField]
    private bool isCoroutineRunning = false;
    public Collectible collectible;

    private void Awake()
    {
        if (isImage)
        {
            textHolder = transform.GetChild(1).gameObject;
            text = transform.GetChild(1).GetChild(0).GetChild(4).gameObject.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            textHolder = transform.GetChild(1).gameObject;
            text = transform.GetChild(1).GetChild(0).GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        }
        
        text.text = InputText;
    
        //Set collectible to uncollected, use backup text if no collectible
        if(collectible)
        {
            collectible.collected = false;
            text.text = collectible.description;
        }
        else
        {
            text.text = InputText;
        }
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
                //Set collectible as collected if exists
                if(collectible)
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