using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivatorKeyword : MonoBehaviour
{
    public GameObject DialogueHolder;
    public DialogueKeyWord dialogue;
    public GameObject keyword;

    public void StartDialogue()
    {
        keyword.SetActive(false);
        DialogueHolder.SetActive(true);
        Talking();
    }

    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
