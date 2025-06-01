using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class SaveAndLoadRoute : MonoBehaviour
{
    public int Route1;
    void Start()
    {
        LoadLastRoute();
    }

    public void SaveLastRoute()
    {
        PlayerPrefs.SetInt("Route1", 1);
    }

    public void LoadLastRoute()
    {
        Route1 = PlayerPrefs.GetInt("Route1");
    }

    public void ResetRoute()
    {
        PlayerPrefs.SetInt("Route1", 0);
    }
}
