using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToEnd : MonoBehaviour
{
    public Animator transition;

    public void Transition()
    {
        transition.Play("TransitionToEnd");

    }
}
