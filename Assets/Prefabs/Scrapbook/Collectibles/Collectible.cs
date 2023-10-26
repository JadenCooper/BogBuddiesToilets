using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collectible : ScriptableObject
{
    public string title;
    [TextAreaAttribute]
    public string description;
    public string imageDescription;
    public Sprite background;
    public Sprite picture;
    public bool collected;
}
