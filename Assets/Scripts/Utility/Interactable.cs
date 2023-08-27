using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [ContextMenu("Interact")]
    public abstract void Interact();
}
