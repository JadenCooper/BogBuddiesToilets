using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioChangerManager : MonoBehaviour
{
    public AudioSource topSideAudio;
    public AudioSource playerFootSteps;
    public AudioClip playerTopSideFootSteps;
    public AudioReverbZone bottomSideReverbZone;
    public AudioClip playerBottomSideFootSteps;
    public AudioSource bottomSideAudio;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "New Player")
        {
            topSideAudio.enabled = false;
            bottomSideAudio.enabled = true;
            bottomSideReverbZone.enabled = true;
            playerFootSteps.clip = playerBottomSideFootSteps;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "New Player")
        {
            bottomSideReverbZone.enabled = false;
            bottomSideAudio.enabled = false;
            topSideAudio.enabled = true;
            playerFootSteps.clip = playerTopSideFootSteps;
        }
    }
}
