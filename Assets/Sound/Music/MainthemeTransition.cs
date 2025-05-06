using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainthemeTransition : MonoBehaviour
{
    [Header("audio start play")]
    [SerializeField] AudioSource musicSource;
    //public AudioClip MainLoudTheme;
    public bool musicTransition;


    public void EnableTransition()
    {
        musicSource.Play();
        musicTransition = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (musicTransition == true)
        {
            if (musicSource.volume < 0.5)
            {
                musicSource.volume += 0.001f;
            }
            if (musicSource.volume >= 0.5)
            {
                musicTransition = false;
            }
        }
    }
}
