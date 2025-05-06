using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusicShareYourKnowledge : MonoBehaviour
{
    public GameObject MusicChange;

    public void Music()
    {
        MusicChange = GameObject.Find("FourthMusicTransition");

        MusicChange.GetComponent<MusicChange>().ChangeClip();
    }
}
