using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartMichaelMonologueAfterAppleQuest : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    public void StartMonologue()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
