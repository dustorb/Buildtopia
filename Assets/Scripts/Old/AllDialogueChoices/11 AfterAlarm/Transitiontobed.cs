using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitiontobed : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject SixMusicTransition;

    public void Transition()
    {
        SixMusicTransition = GameObject.Find("SixMusicTransition");
        SixMusicTransition.GetComponent<MusicChange>().ChangeClip();
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
    }
}
