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

    [SerializeField]
    private float RefilTime = 5f;
    private bool Refiling = false;
    private bool CompletedRefil = true;
    void Update()
    {
        //if (!ToiletChain.open)
        //{
        //    WaterObjects.SetActive(true);
        //    if (count <= FRAMES)
        //    {
        //        if (count % OCCURANCE == 0)
        //        {
        //            FillingWater.transform.localScale += new Vector3(0, 0, SIZE);
        //            FillingWater.transform.localPosition += new Vector3(0, DISTANCE, 0);
        //        }
        //        count++;
        //    }
        //    else
        //    {
        //        Water.SetActive(false);
        //    }
        //}
        //else
        //{
        //    if (count > 0)
        //    {
        //        if (count % OCCURANCE == 0)
        //        {
        //            FillingWater.transform.localScale -= new Vector3(0, 0, SIZE);
        //            FillingWater.transform.localPosition -= new Vector3(0, DISTANCE, 0);
        //        }
        //        count--;
        //        if (count == 0)
        //        {
        //            FillingWater.transform.localScale -= new Vector3(0, 0, SIZE);
        //            FillingWater.transform.localPosition -= new Vector3(0, DISTANCE, 0);
        //        }
        //    }
        //    if (count == 0 && Refiling == false)
        //    {
        //        Refiling = true;
        //        Water.SetActive(true);
        //        WaterObjects.SetActive(false);
        //        StartCoroutine(refill());
        //    }
        //}
    }
    public void Activate()
    {
        Debug.Log("Check");
        if (!CompletedRefil)
        {
            CompletedRefil = false;
            int count = 0;
            bool stageCompleted = false;

            do
            {
                if (!Refiling)
                {
                    if (count == FRAMES)
                    {
                        stageCompleted = true;
                    }
                    else
                    {
                        StartCoroutine(refill(false));
                        count++;
                    }
                }
            } while (!stageCompleted);

            count = 0;
            stageCompleted = false;
            Water.SetActive(true);

            do
            {
                if (!Refiling)
                {
                    if (count == FRAMES)
                    {
                        stageCompleted = true;
                    }
                    else
                    {
                        StartCoroutine(refill(true));
                        count++;
                    }
                }
            } while (!stageCompleted);
            Water.SetActive(false);
        }
    }
    private IEnumerator refill(bool filling)
    {
        yield return new WaitForSeconds(2f);
        if (filling)
        {
            FillingWater.transform.localScale += new Vector3(0, 0, SIZE);
            FillingWater.transform.localPosition += new Vector3(0, DISTANCE, 0);
        }
        else
        {
            FillingWater.transform.localScale -= new Vector3(0, 0, SIZE);
            FillingWater.transform.localPosition -= new Vector3(0, DISTANCE, 0);
        }
    }
}
