using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip WindowsSetup;
    public AudioClip WindowsTurnOff;

    public void PlaySetup()
    {
        musicSource.clip = WindowsSetup;
        musicSource.Play();
    }

    public void PlayTurnOff()
    {
        musicSource.clip = WindowsTurnOff;
        musicSource.Play();
    }
}
