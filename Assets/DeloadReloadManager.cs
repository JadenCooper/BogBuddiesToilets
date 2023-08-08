using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeloadReloadManager : MonoBehaviour
{
    public GameObject[] load;
    public bool deloadOnStart;
    public bool loadOnEnter;

    [ContextMenu("Assign Game Objects To Deload")] // Allows Developer To Activate The Method Through The Context Menu In The Inspector
    public void AssignGameObjectsToDeload()
    {
        load = GameObject.FindGameObjectsWithTag(gameObject.name);

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
        foreach (GameObject gameObject in load)
        {
            if (gameObject != null)
            {
                gameObject.SetActive(setState);
            }
        }
    }
}
