using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.UI.VirtualMouseInput;

public class Crosshair : MonoBehaviour
{
    private GameObject CrosshairObject;
    public Texture2D cursorTexture;
    public UnityEngine.CursorMode cursorMode = UnityEngine.CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    private void Start()
    {
        CrosshairObject = gameObject;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        gameObject.SetActive(false);
    }
    private void Update()
    {
        // Makes Sure Crosshair Is Exactly Where The Mouse Is
        CrosshairObject.transform.position = Input.mousePosition;
    }
}
