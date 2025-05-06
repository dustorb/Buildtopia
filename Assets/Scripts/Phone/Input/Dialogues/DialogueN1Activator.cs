using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueN1Activator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public DialogueN1 dialogue;
    public GameObject phoneCanvas;

    public void StartDialogue()
    {
        phoneCanvas.SetActive(false);
        DialogueHolder.SetActive(true);
        Talking();
    }

    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
