using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circlesindreamappear : MonoBehaviour
{
    public GameObject circleL;
    //public GameObject circleR;
    public GameObject circleB;

    public void CirclesAppear()
    {
        circleL = GameObject.Find("circleL");
        //circleR = GameObject.Find("circleR");
        circleB = GameObject.Find("circleB");
        //circleL.SetActive(true);
        //circleR.SetActive(true);
        circleL.GetComponent<Animator>().Play("Fade");
        //circleR.GetComponent<Animator>().Play("Appear");
        circleB.GetComponent<Animator>().Play("Appear");
    }
}
