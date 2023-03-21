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
        
    }
}
