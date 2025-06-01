using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveAndLoadVolume : MonoBehaviour
{
    public Slider master;
    public Slider music;
    public Slider sound;

    void Start()
    {
        LoadVolume();
    }

    void Update()
    {
        SaveVolume();
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("masterVolume", master.value);
        PlayerPrefs.SetFloat("musicVolume", music.value);
        PlayerPrefs.SetFloat("soundVolume", sound.value);
    }

    public void LoadVolume()
    {
        master.value = PlayerPrefs.GetFloat("masterVolume");
        music.value = PlayerPrefs.GetFloat("musicVolume");
        sound.value = PlayerPrefs.GetFloat("soundVolume");
    }
}
