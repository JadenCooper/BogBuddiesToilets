using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeloadReloadManager : MonoBehaviour
{
    public List<GameObject> Load;

    void Awake()
    {
        foreach (GameObject gameObject in Load)
        {
            if(gameObject != null)
            {
                gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            foreach (GameObject gameObject in Load)
            {
            if(gameObject != null)
            {
                gameObject.SetActive(true);
            }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            foreach (GameObject gameObject in Load)
            {
            if(gameObject != null)
            {
                gameObject.SetActive(false);
            }
            }
        }
    }
}
