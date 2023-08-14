using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WaypointData
{
    public static readonly Dictionary<TransportLocation, Vector3[]> Locations = new Dictionary<TransportLocation, Vector3[]>()
    {
        { TransportLocation.FG, new Vector3[] { new Vector3(97.3310013f, 41.5699997f, -50.4099998f), new Vector3( 0, 0, 0)} }, // Waypoint 
        { TransportLocation.TS, new Vector3[] { new Vector3(98.6600037f, 41.818924f, -38.6599998f), new Vector3( -180, 0, 0)} }, // Waypoint 12
        { TransportLocation.TL, new Vector3[] { new Vector3(100.57f, 41.6039238f, -55.4399986f), new Vector3( 150, 0, 0)} }, // Waypoint 13
        { TransportLocation.TR, new Vector3[] { new Vector3(89.6699982f, 41.6039238f, -54.7400017f), new Vector3( 230, 0, 0)} }, // Waypoint 14

        { TransportLocation.FTS, new Vector3[] { new Vector3(103.290001f, 41.9087753f, -46.0279999f), new Vector3( -90, 0, 0)} }, // Waypoint 7
        { TransportLocation.FMA, new Vector3[] { new Vector3(101.402f, 38.5020447f, -45.0690002f), new Vector3( -90, 0, 0)} }, // Waypoint 8
        { TransportLocation.FBOR, new Vector3[] { new Vector3(101.768074f, 38.5020447f, -47.2829247f), new Vector3( -90, 0, 0)} }, // Waypoint 9
        { TransportLocation.FBSR, new Vector3[] { new Vector3(99.6279984f, 38.5020447f, -47.154953f), new Vector3( -100, 0, 0)} }, // Waypoint 10
        { TransportLocation.FTTC, new Vector3[] { new Vector3(100.149002f, 38.5020447f, -42.5741501f), new Vector3( -100, 0, 0)} }, // Waypoint 11

        { TransportLocation.MTS, new Vector3[] { new Vector3(91.8410034f, 41.5019684f, -45.0130005f), new Vector3( 90, 0, 0)} }, // Waypoint 1
        { TransportLocation.MF, new Vector3[] { new Vector3(96.9229965f, 38.5020447f, -47.0587769f), new Vector3( -70, 0, 0)} }, // Waypoint 6
        { TransportLocation.MB, new Vector3[] { new Vector3(96.7070007f, 38.5020447f, -43.0667763f), new Vector3( -110, 0, 0)} }, // Waypoint 2
        { TransportLocation.MM, new Vector3[] { new Vector3(95.038002f, 38.5020447f, -44.9729538f), new Vector3( -90, 0, 0)} }, // Waypoint 3
        { TransportLocation.MLR, new Vector3[] { new Vector3(93.0690002f, 38.5020447f, -46.1887779f), new Vector3( -110, 0, 0)} }, // Waypoint 4
        { TransportLocation.MRR, new Vector3[] { new Vector3(93.1559982f, 38.5020447f, -43.9900017f), new Vector3( -110, 0, 0)} }, // Waypoint 5
    };
}
