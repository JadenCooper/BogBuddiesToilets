using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    public GameObject light;
    public void Toggle()
    {
        light.SetActive(!light.activeSelf);
    }
}
