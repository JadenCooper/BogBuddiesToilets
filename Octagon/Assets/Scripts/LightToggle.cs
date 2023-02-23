using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    private bool active;
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        light.SetActive(active);
    }
    public void Toggle()
    {
        active = !active;
    }
}
