using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject LeftTap;
    public GameObject RightTap;
    public GameObject WaterObjects;
    public GameObject FillingWater;
    private const float DISTANCE = 0.01f;
    private const float SIZE = 0.01f;
    private const int FRAMES = 10;
    private const int OCCURANCE = 2;
    private int count;

    void Start()
    {
        count = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (!LeftTap.GetComponent<Rotation>().open || !RightTap.GetComponent<Rotation>().open)
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
                WaterObjects.SetActive(false);
            }
        }
    }
}
