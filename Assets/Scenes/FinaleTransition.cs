using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinaleTransition : MonoBehaviour
{
    public AudioSource ringing;
    public GameObject blackBG;

    // Start is called before the first frame update
    void Start()
    {
        ringing.Play();
        blackBG.SetActive(true);
        blackBG.GetComponent<Animator>().Play("Play");
    }

   
}
