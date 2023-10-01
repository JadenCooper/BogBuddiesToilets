using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WaypointData
{
    public static readonly Dictionary<TransportLocation, Vector3[]> Locations = new Dictionary<TransportLocation, Vector3[]>()
    {
        { TransportLocation.FG, new Vector3[] { new Vector3(10.6889858f, 12.2157383f, -10.9503698f), new Vector3(1.892f, 0, 0)} }, // Waypoint  // Front Gate // Done
        { TransportLocation.TS, new Vector3[] { new Vector3(14.3428221f, 13.2907372f, 46.1027184f), new Vector3( 180, 0, 0)} }, // Waypoint 12 // Topside Street // Done
        { TransportLocation.TL, new Vector3[] { new Vector3(100.57f, 41.6039238f, -55.4399986f), new Vector3( 150, 0, 0)} }, // Waypoint 13 // Topside Left // No Longer Present
        { TransportLocation.TR, new Vector3[] { new Vector3(89.6699982f, 41.6039238f, -54.7400017f), new Vector3( 230, 0, 0)} }, // Waypoint 14 // Topside Right // No Longer Present

        { TransportLocation.FTS, new Vector3[] { new Vector3(34.9328384f, 10.6253805f, 10.8837128f), new Vector3(17.728f,  0, 0)} }, // Waypoint 7 // Female Top Stairs // Done
        { TransportLocation.FMA, new Vector3[] { new Vector3(28.3935986f, -4.83457756f, 16.0621986f), new Vector3(227.524f, 0, 0)} }, // Waypoint 8 // Female Main Area // Done
        { TransportLocation.FBOR, new Vector3[] { new Vector3(32.417881f, -4.83457518f, 3.71320486f), new Vector3(298.7337f, 0, 0)} }, // Waypoint 9 // Female Blocked Off Area // Done
        { TransportLocation.FBSR, new Vector3[] { new Vector3(20.0735855f, -4.83457518f, 2.84657288f), new Vector3(-41.49135f, 0, 0)} }, // Waypoint 10 // Female Big Side Room // Done
        { TransportLocation.FTTC, new Vector3[] { new Vector3(24.0433483f, -4.83461714f, 28.4492645f), new Vector3(255.1865f, 0, 0)} }, // Waypoint 11 // Female Two Toilet Corner  // Done

        { TransportLocation.MTS, new Vector3[] { new Vector3(-20.0893555f, 11.6958885f, 16.4028778f), new Vector3(87.289f, 0, 0)} }, // Waypoint 1 // Male Top Stairs // Done
        { TransportLocation.MF, new Vector3[] { new Vector3(7.67076111f, -4.83457518f, 4.29062557f), new Vector3(294.1601f, 0, 0)} }, // Waypoint 6 // Male Front // Done
        { TransportLocation.MB, new Vector3[] { new Vector3(4.91224957f, -4.83457899f, 26.9094543f), new Vector3(-124.3592f, 0, 0)} }, // Waypoint 2 // Male Back // Done
        { TransportLocation.MM, new Vector3[] { new Vector3(-3.26185608f, -4.83457708f, 16.135767f), new Vector3(-91.81805f, 0, 0)} }, // Waypoint 3 // Male Main // Done
        { TransportLocation.MLR, new Vector3[] { new Vector3(-12.7910938f, -4.83457661f, 10.4777927f), new Vector3(41.94468f, 0, 0)} }, // Waypoint 4 // Male Left Room // Done 
        { TransportLocation.MRR, new Vector3[] { new Vector3(-12.7713413f, -4.83457899f, 23.3903961f), new Vector3(-182.5142f, 0, 0)} }, // Waypoint 5 // Male Right Room // Done
    };
}
