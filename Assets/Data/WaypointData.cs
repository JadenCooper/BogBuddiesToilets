using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WaypointData
{
    public static readonly Dictionary<TransportLocation, Vector3[]> Locations = new Dictionary<TransportLocation, Vector3[]>()
    {
        { TransportLocation.FG, new Vector3[] { new Vector3(107.376091f, 51.4351807f, -63.2159081f), new Vector3(1.892f, 0, 0)} }, // Waypoint  // Front Gate // Done
        { TransportLocation.TS, new Vector3[] { new Vector3(110.631264f, 54.4205513f, -1.34731674f), new Vector3( 180, 0, 0)} }, // Waypoint 12 // Topside Street // Done
        { TransportLocation.TL, new Vector3[] { new Vector3(100.57f, 41.6039238f, -55.4399986f), new Vector3( 150, 0, 0)} }, // Waypoint 13 // Topside Left // No Longer Present
        { TransportLocation.TR, new Vector3[] { new Vector3(89.6699982f, 41.6039238f, -54.7400017f), new Vector3( 230, 0, 0)} }, // Waypoint 14 // Topside Right // No Longer Present

        { TransportLocation.FTS, new Vector3[] { new Vector3(129.357224f, 49.8230095f, -39.5336151f), new Vector3(17.728f,  0, 0)} }, // Waypoint 7 // Female Top Stairs // Done
        { TransportLocation.FMA, new Vector3[] { new Vector3(124.989273f, 34.3848686f, -31.4489422f), new Vector3(227.524f, 0, 0)} }, // Waypoint 8 // Female Main Area // Done
        { TransportLocation.FBOR, new Vector3[] { new Vector3(129.328644f, 34.3848686f, -44.4809723f), new Vector3(285.797f, 0, 0)} }, // Waypoint 9 // Female Blocked Off Area // Done
        { TransportLocation.FBSR, new Vector3[] { new Vector3(113.987595f, 34.3848686f, -42.5126114f), new Vector3( 131.499f, 0, 0)} }, // Waypoint 10 // Female Big Side Room // Done
        { TransportLocation.FTTC, new Vector3[] { new Vector3(119.315796f, 34.3848648f, -19.0100975f), new Vector3(254.069f, 0, 0)} }, // Waypoint 11 // Female Two Toilet Corner  // Done

        { TransportLocation.MTS, new Vector3[] { new Vector3(75.8797836f, 50.9153328f, -32.4813423f), new Vector3(87.289f, 0, 0)} }, // Waypoint 1 // Male Top Stairs // Done
        { TransportLocation.MF, new Vector3[] { new Vector3(100.442619f, 34.3848686f, -42.9141655f), new Vector3(332.675f, 0, 0)} }, // Waypoint 6 // Male Front // Done
        { TransportLocation.MB, new Vector3[] { new Vector3(99.8157883f, 34.3848648f, -21.637043f), new Vector3(95.483f, 0, 0)} }, // Waypoint 2 // Male Back // Done
        { TransportLocation.MM, new Vector3[] { new Vector3(93.4923935f, 34.3848648f, -30.7612286f), new Vector3(255.853f, 0, 0)} }, // Waypoint 3 // Male Main // Done
        { TransportLocation.MLR, new Vector3[] { new Vector3(83.7100906f, 34.3848686f, -39.5767021f), new Vector3(313.936f, 0, 0)} }, // Waypoint 4 // Male Left Room // Done
        { TransportLocation.MRR, new Vector3[] { new Vector3(82.3541946f, 34.3848648f, -25.6635742f), new Vector3(323.925f, 0, 0)} }, // Waypoint 5 // Male Right Room // Done
    };
}
