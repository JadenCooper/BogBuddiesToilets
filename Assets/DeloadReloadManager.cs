using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeloadReloadManager : MonoBehaviour
{
    public List<GameObject> load;

    void Awake()
    {
        for(int i = 0; i < load.Count; i++)
        {
            if(gameObject == null){
                load[i].SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            for (int i = 0; i < load.Count; i++)
            {
                if (load[i] == null){
                    load[i].SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            for (int i = 0; i < load.Count; i++)
            {
                if (load[i] == null){
                    load[i].SetActive(false);
                }
            }
        }
    }
}
