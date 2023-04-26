using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public ArrowManager arrowManager;
    //Location You are Moving to
    public Vector3 moveTo;
    //rotation of character after teleportation.
    public float rotation;
    public void Teleport()
    {
        arrowManager.MovePlayer(moveTo, rotation);
    }
}
