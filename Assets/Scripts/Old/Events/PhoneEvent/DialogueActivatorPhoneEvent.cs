using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivatorPhoneEvent : MonoBehaviour
{
    public GameObject DialogueHolder;
    public DialoguePhoneEvent dialogue;
   
    public void StartDialogue()
    {
        DialogueHolder.SetActive(true);
        Talking();
    }

    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
