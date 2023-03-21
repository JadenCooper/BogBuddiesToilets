using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using System;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public GameObject text;
    public String InputText;
    private void Start()
    {
        text.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = InputText;
    }
}