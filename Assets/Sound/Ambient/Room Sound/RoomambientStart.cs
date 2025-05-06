using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomambientStart : MonoBehaviour
{
    public AudioSource Ceiling;
    public AudioSource Street;
    public AudioSource Cars;

    public bool transition;
    //public float CeilingVolume;
    //public float StreetVolume;
    //public float CarsVolume; 

    void Start()
    {
        StartCoroutine(LogoFadePause());
        
    }

    void Update()
    {
        if (transition == true && Ceiling.volume < 0.4 && Street.volume < 0.4 && Cars.volume < 0.4)
        {
            Ceiling.volume += 0.001f;
            Street.volume += 0.001f;
            Cars.volume += 0.001f;

           
        }

        if (Ceiling.volume >= 1 && Street.volume >= 0.4 && Cars.volume >= 0.4)
        {
            transition = false;
        }
       
        
    }

    IEnumerator LogoFadePause()
    {
        yield return new WaitForSeconds(2f);
        transition = true;
    }
}
