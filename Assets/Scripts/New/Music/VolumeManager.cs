using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixerGroup group;

    public void SetMasterVolume(float vol)
    {
        audioMixer.SetFloat("vol", vol);
    }

    public void SetMusicVolume(float mvol)
    {
        audioMixer.SetFloat("mvol", mvol);
    }

    public void SetSoundVolume(float svol)
    {
        audioMixer.SetFloat("svol", svol);
    }
}
