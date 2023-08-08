using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour
{
    public Rotation ToiletChain;
    public GameObject WaterObjects;
    public GameObject FillingWater;
    public GameObject Water;
    private const float DISTANCE = 0.01f;
    private const float SIZE = 0.01f;
    private const int FRAMES = 10;
    private const int OCCURANCE = 2;
    public int count = 0;
    void Update()
    {
        if (!ToiletChain.open)
        {
            WaterObjects.SetActive(true);
            if (count <= FRAMES)
            {
                if (count % OCCURANCE == 0)
                {
                    FillingWater.transform.localScale += new Vector3(0, 0, SIZE);
                    FillingWater.transform.localPosition += new Vector3(0, DISTANCE, 0);
                }
                count++;
            }
            else
            {
                Water.SetActive(false);
            }
        }
        else
        {
            if (count > 0)
            {
                if (count % OCCURANCE == 0)
                {
                    FillingWater.transform.localScale -= new Vector3(0, 0, SIZE);
                    FillingWater.transform.localPosition -= new Vector3(0, DISTANCE, 0);
                }
                count--;
                if (count == 0)
                {
                    FillingWater.transform.localScale -= new Vector3(0, 0, SIZE);
                    FillingWater.transform.localPosition -= new Vector3(0, DISTANCE, 0);
                }
            }
            if (count == 0)
            {
                Water.SetActive(true);
                WaterObjects.SetActive(false);
            }
        }
    }
}
