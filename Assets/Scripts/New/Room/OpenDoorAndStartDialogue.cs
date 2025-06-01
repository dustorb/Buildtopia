using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using Cinemachine;


public class OpenDoorAndStartDialogue : MonoBehaviour
{
    public Animator door;
    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private NPCConversation myConversation1;

    public CinemachineVirtualCamera vc;

    public SaveAndLoadRoute SaveAndLoadRoute;

    void Start()
    {
        StartCoroutine(OpenDoorAndDialogue());
    }

    public void OpenDoor()
    {
        StartCoroutine(OpenDoorAndDialogue());
    }

    IEnumerator OpenDoorAndDialogue()
    {
        yield return new WaitForSeconds(3f);
        door.Play("DoorPlay");
        vc.m_Priority = 2;

        if (SaveAndLoadRoute.Route1 == 1)
        {
            ConversationManager.Instance.StartConversation(myConversation1);
        }
        else
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
        
    }
}
