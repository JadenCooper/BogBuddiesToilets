using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using System;
using UnityEngine.UI;
using TMPro;

public class ArrowMovement : MonoBehaviour
{
    //Location You are Moving to
    public Vector3 moveTo;
    //Starting Text of the Arrow
    public string startingText;
    //Gameobject refering where the text is.
    public TextMeshProUGUI text;
    //rotation of character after teleportation.
    public float rotation;
    //Location of arrows at the new location.
    public GameObject LocationArrows;

    // Start is called before the first frame update
    void Start()
    {
        text.text = startingText;
    }
}
