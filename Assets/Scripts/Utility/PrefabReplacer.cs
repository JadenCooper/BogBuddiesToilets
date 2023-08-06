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
        GameObject prefabParent = new GameObject(Prefab.name + " Parent");

        for (int i = 0; i < ObjectsToReplace.Count; i++)
        {
            GameObject newObject = Instantiate(Prefab);
            newObject.transform.parent = prefabParent.transform;

            newObject.transform.rotation = ObjectsToReplace[i].transform.rotation;
            newObject.transform.position = ObjectsToReplace[i].transform.position;

            Destroy(ObjectsToReplace[i]);
        }

        ObjectsToReplace.Clear();
    }
}
