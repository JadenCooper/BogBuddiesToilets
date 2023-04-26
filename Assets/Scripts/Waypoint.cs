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
    public TransportLocation transportLocation;
    public void Teleport()
    {
        arrowManager.MovePlayer(moveTo, rotation);
        //arrowManager.OpenArrows(transportLocation);
    }

    public void Initialize()
    {
        Vector3[] temp = WaypointData.Locations[transportLocation];
        rotation = temp[1].x;
        moveTo = temp[0];
    }

    private void Awake()
    {
        Initialize();
    }
}
