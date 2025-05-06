using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneEvent : MonoBehaviour
{
    public bool isRinging;
    public GameObject RingingPhoneCollider;
    public DialogueActivatorPhoneEvent dialogue;
    public StartingDialogue StartingDialogue;

    // Update is called once per frame
    void Update()
    {

        if (StartingDialogue.PhoneCanRing == true)
        {
            isRinging = true;
            StartingDialogue.PhoneCanRing = false;
        }
        if (isRinging)
        {
            RingingPhoneCollider.SetActive(true); 
        }
    }

    public void PickUpThePhone()
    {
        dialogue.StartDialogue();
    }


}
