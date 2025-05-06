using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionV2 : MonoBehaviour
{
    public GameObject TransitionController;
    public GameObject MusicChange;

    void Start()
    {
        TransitionController = GameObject.Find("TransitionController2");
        MusicChange = GameObject.Find("FirstMusicTransition");
    }

    public void StartTransition()
    {
        TransitionController.GetComponent<TransitionB2>().StartTrans();
        MusicChange.GetComponent<MusicChange>().ChangeClip();
    }
}
