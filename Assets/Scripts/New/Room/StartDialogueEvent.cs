using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartDialogueEvent : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;

    public float time = 2f;
    public void StartDialogue()
    {
        StartCoroutine(Dialogue());
    }

    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(time);
        ConversationManager.Instance.StartConversation(myConversation);

    }
}
