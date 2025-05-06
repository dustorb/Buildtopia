using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyWordTransition : MonoBehaviour
{
    public GameObject TransitionBG;

    public void Transition()
    {
        Instantiate(TransitionBG);
    }

}
