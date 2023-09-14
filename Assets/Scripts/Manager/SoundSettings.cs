using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public Slider MusicSlider;
    public Slider SoundEffectSlider;
    public AudioMixer MusicMixer;
    public AudioMixer SoundEffectMixer;
    void Start()
    {
        SetMusicVolume(PlayerPrefs.GetFloat("SavedMusicVolume", 100));
        SetSoundEffectVolume(PlayerPrefs.GetFloat("SavedSoundEffectVolume", 100));
    }

    public void SetMusicVolume(float value)
    {
        if (value < 1)
        {
            value = 0.001f;
        }
        RefreshSlider(value, MusicSlider);
        PlayerPrefs.SetFloat("SavedMusicVolume", value);
        MusicMixer.SetFloat("MasterVolume", Mathf.Log10(value / 100) * 20f);
    }
    public void SetSoundEffectVolume(float value)
    {
        if (value < 1)
        {
            value = 0.001f;
        }
        RefreshSlider(value, SoundEffectSlider);
        PlayerPrefs.SetFloat("SavedSoundEffectVolume", value);
        SoundEffectMixer.SetFloat("MasterVolume", Mathf.Log10(value / 100) * 20f);
    }
    public void SetVolumeFromSlider()
    {
        //SetVolume(MusicSlider.value);
    }
    public void RefreshSlider(float value, Slider slider)
    {
        slider.value = value;
    }
}
