using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCollidersDisableDialogue : MonoBehaviour
{
    public GameObject canvas;
    public GameObject switchTowindows;
    public GameObject switchToboard;
    public GameObject switchTophone; 

    public void EnableCollidersStopDialogue()
    {
        canvas.SetActive(false);
        switchToboard.SetActive(true);
        switchTowindows.SetActive(true);
        switchTophone.SetActive(true);
    }
}
