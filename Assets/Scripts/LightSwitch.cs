using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{
    public List<GameObject> lights = new List<GameObject>();
    public List<GameObject> lightBulbs = new List<GameObject>();
    public override void Interact()
    {
        foreach (GameObject light in lights)
        {
            light.SetActive(!light.activeSelf);
        }
        foreach (GameObject bulb in lightBulbs)
        {
            Renderer renderer = bulb.GetComponent<Renderer>();
            if (!renderer.material.IsKeywordEnabled("_EMISSION"))
            {
                renderer.material.EnableKeyword("_EMISSION");
                renderer.material.SetColor("_EmissionColor", Color.white);
            }
            else
            {
                renderer.material.DisableKeyword("_EMISSION");
            }
        }
    }
}
