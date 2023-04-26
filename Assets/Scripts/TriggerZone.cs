using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        target.SetActive(false);
    }

    public void OnTriggerEnter(Collider obj)
    {
        target.SetActive(true);
    }
    public void OnTriggerExit(Collider obj)
    {
        target.SetActive(false);
    }
}
