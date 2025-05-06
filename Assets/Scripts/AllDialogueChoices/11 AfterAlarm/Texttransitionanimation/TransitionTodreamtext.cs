using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TransitionTodreamtext : MonoBehaviour
{
    public GameObject BG;
    public GameObject text;

    public void Change()
    {
        BG.SetActive(true);
        BG.GetComponent<Animator>().Play("Play");
        text.GetComponent<Animator>().Play("Play2");
    }
}
