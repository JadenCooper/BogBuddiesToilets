using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAudioSourcesManager : MonoBehaviour
{
    public AudioSource[] allAudioSources;
    public AudioSource[] soundEffectSources;
    public AudioSource[] musicSources;

    public static AllAudioSourcesManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }   
    }

    public void AdjustVolumneSoundEffect(float newVolumne)
    {
        foreach(AudioSource audioSource in soundEffectSources)
        {
            audioSource.volume = newVolumne;
        }
    }

    public void AdjustVolumneMusic(float newVolumne)
    {
        foreach (AudioSource audioSource in musicSources)
        {
            audioSource.volume = newVolumne;
        }
    }

    public void AdjustVolumneMaster(float newVolumne)
    {
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.volume = newVolumne;
        }
    }
}
