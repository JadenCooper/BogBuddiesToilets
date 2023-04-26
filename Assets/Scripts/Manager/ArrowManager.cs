using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public  Transform Player;
    public List<ArrowHolder> ArrowHolders;
    public void MovePlayer(Vector3 moveTo, float Rotation)
    {
        Player.SetPositionAndRotation(moveTo, Quaternion.Euler(0, Rotation, 0));
    }

    public void OpenArrows(TransportLocation newLocation)
    {
        foreach (ArrowHolder arrowHolder in ArrowHolders)
        {
            if (arrowHolder.transportLocation == newLocation)
            {
                arrowHolder.gameObject.SetActive(true);
                Debug.Log("Open");
            }
            else
            {
                arrowHolder.gameObject.SetActive(false);
                Debug.Log("Close");
            }
        }
    }
}
