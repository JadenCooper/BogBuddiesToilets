using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabReplacer : MonoBehaviour
{
    public List<GameObject> ObjectsToReplace = new List<GameObject>();
    public GameObject Prefab;

    [ContextMenu("Replace Gameobjects With Prefab")]
    public void ReplaceGameObjects()
    {
        for (int i = 0; i < ObjectsToReplace.Count; i++)
        {
            GameObject newObject = Instantiate(Prefab);
            newObject.transform.parent = ObjectsToReplace[i].transform.parent;

            newObject.transform.rotation = ObjectsToReplace[i].transform.rotation;
            newObject.transform.position = ObjectsToReplace[i].transform.position;

            DestroyImmediate(ObjectsToReplace[i]);
        }

        ObjectsToReplace.Clear();
    }
}
