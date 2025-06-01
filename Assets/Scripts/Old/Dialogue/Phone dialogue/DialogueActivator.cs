using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public Dialogue dialogue;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    //Canvas.SetActive(true);
        //    DialogueHolder.SetActive(true);
        //    Talking();
        //}
    }

    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
