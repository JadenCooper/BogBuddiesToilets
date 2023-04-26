using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WaypointData
{
    public static readonly Dictionary<int, Vector3> Cells = new Dictionary<int, Vector3>()
    {
        { 0, new Vector3[] { new Vector3(-1, 1), new Vector3( 0, 1)} },
    };
}
