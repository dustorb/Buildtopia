using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongNumberActivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public WrongDialogue dialogue;
    public GameObject numbersCanvas;

    public void StartDialogue()
    {
        numbersCanvas.SetActive(false);
        DialogueHolder.SetActive(true);
        Talking();
    }

    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
