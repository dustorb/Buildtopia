using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTodream1music : MonoBehaviour
{
    public GameObject SevenMusicTransition;

    public void Trans()
    {
        SevenMusicTransition = GameObject.Find("SevenMusicTransition");
        SevenMusicTransition.GetComponent<MusicChange>().ChangeClip();
    }
}
