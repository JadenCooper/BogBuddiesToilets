using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject objectToDestroy;
    public MouseLook mouseLook;
    public void DestroyObject()
    {
        //mouseLook.mouseLocked = false;
        Destroy(objectToDestroy);
    }
}
