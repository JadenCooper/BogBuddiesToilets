using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeloadReloadManager : MonoBehaviour
{
    public List<GameObject> Load;
    public bool deloadOnStart;
    public bool loadOnEnter;

    void Awake()
    {
        if(deloadOnStart == true)
        {
            DeloaderLoader(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            if (loadOnEnter == true)
            {
                DeloaderLoader(true);
            }
            else
            {
                DeloaderLoader(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            if (loadOnEnter == true)
            {
                DeloaderLoader(false);
            }
            else
            {
                DeloaderLoader(true);
            }
        }
    }

    public void DeloaderLoader(bool setState)
    {
        foreach (GameObject gameObject in Load)
        {
            if (gameObject != null)
            {
                gameObject.SetActive(setState);
            }
        }
    }
}
