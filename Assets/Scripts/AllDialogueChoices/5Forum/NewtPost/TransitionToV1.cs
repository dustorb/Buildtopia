using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToV1 : MonoBehaviour
{
    public GameObject TransitionController;
    public GameObject MusicChange;

    void Start()
    {
        TransitionController = GameObject.Find("TransitionController");
        MusicChange = GameObject.Find("FifthMusicTransition");
    }

    public void StartTransition()
    {
        TransitionController.GetComponent<BTransition>().StartTrans();
        MusicChange.GetComponent<MusicChange>().ChangeClip();
    }
}
