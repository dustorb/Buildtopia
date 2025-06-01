using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBeforeFirstInteractionWithComputer : MonoBehaviour
{
    public MouseClickDetector MouseClickDetector;

    public void EnableDialogueBeforeFirstComputerInteraction()
    {
        MouseClickDetector.beforefirstcomputerinteraction = true;
    }
}
