using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightManager : MonoBehaviour
{
    public GameObject Sun;
    public List<GameObject> LampPostLights = new List<GameObject>();

    [ContextMenu("Toggle Night Day")] // Allows Developer To Activate The Method Through The Context Menu In The Inspector
    public void ToggleNightDay()
    {
        // For Night Sun Will Be Turned Off And The Lights Turned On
        // For Day The Opposite
        Sun.SetActive(!Sun.activeSelf);
        foreach (GameObject Light in LampPostLights)
        {
            Light.SetActive(!Light.activeSelf);
        }
    }
}
