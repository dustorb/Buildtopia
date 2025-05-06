using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomKeyboardsound : MonoBehaviour
{
    [SerializeField] AudioSource musicSource1;
    //[SerializeField] AudioSource musicSource2;
    //[SerializeField] AudioSource musicSource3;
    //[SerializeField] AudioSource musicSource4;
    //[SerializeField] AudioSource musicSource5;

    public AudioClip KeyboardSound1;
    public AudioClip KeyboardSound2;
    public AudioClip KeyboardSound3;
    public AudioClip KeyboardSound4;
    public AudioClip KeyboardSound5;


    void Update()
    {
        if (Input.anyKeyDown && !(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)))
        {
            PlayRandKey();
        }
    }

    public void PlayRandKey()
    {
        var KeyNumber = Random.Range(1, 5);

        switch (KeyNumber)
        {
            case 1:
                //musicSource.clip = KeyboardSound1;
                musicSource1.PlayOneShot(KeyboardSound1);
                break;
            case 2:
                //musicSource.clip = KeyboardSound2;
                musicSource1.PlayOneShot(KeyboardSound2);
                break;
            case 3:
                //musicSource.clip = KeyboardSound3;
                musicSource1.PlayOneShot(KeyboardSound3);
                break;
            case 4:
                //musicSource.clip = KeyboardSound4;
                musicSource1.PlayOneShot(KeyboardSound4);
                break;
            case 5:
                //musicSource.clip = KeyboardSound5;
                musicSource1.PlayOneShot(KeyboardSound5);
                break;
        }
    }
}
