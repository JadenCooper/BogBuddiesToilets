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
    private float invisableTimer = 20f;
    [SerializeField]
    private bool isCoroutineRunning = false;
    private void Start()
    {
        Text.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = InputText;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public override void Interact()
    {
        if (Text.activeSelf)
        {
            StopCoroutine(InvisableTimer());
            isCoroutineRunning = false;
            Text.SetActive(false);
        }
        else
        {
            //Turn On
            Text.SetActive(true);
            StartCoroutine(InvisableTimer());
        }
    }
    public IEnumerator InvisableTimer()
    {
        isCoroutineRunning = true;
        yield return new WaitForSeconds(invisableTimer);
        isCoroutineRunning = false;
        Text.SetActive(false);
    }
}