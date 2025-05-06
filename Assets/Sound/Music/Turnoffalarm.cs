using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnoffalarm : MonoBehaviour
{
    public AudioSource alarmsound;
    public CommentafteralarmActivator comm;
    

    public void TurnOff()
    {
        alarmsound = GameObject.Find("Alarm").GetComponent<AudioSource>();
        comm = GameObject.Find("NewtCommentAfterAlarm").GetComponent<CommentafteralarmActivator>();
        comm.StartingMonologue();
        alarmsound.Pause();
        
    }
}
