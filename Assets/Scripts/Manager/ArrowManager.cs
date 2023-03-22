using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public  Transform Player;
    public void MovePlayer(Vector3 moveTo, float Rotation)
    {
        Player.SetPositionAndRotation(moveTo, Quaternion.Euler(0, Rotation, 0));
    }
}
