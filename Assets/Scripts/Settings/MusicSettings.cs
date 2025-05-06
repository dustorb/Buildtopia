using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{
    public bool settings;
    public GameObject sliders;
    //public GameObject musicSlider;
    //public GameObject soundSlider;
    public AudioSource musicSource;
    public AudioSource soundSource;
    public Slider slider1;
    public Slider slider2;

    public void EnableSettings()
    {
        settings = !settings;

        if (settings == true)
        {
            sliders.SetActive(true);
        }
        if (settings == false)
        {
            sliders.SetActive(false);
        }

    }

    public void ChangeMusicVolume()
    {
        musicSource.volume = slider1.value;
    }

    public void ChangeSoundVolume()
    {
        soundSource.volume = slider2.value;
    }
}
