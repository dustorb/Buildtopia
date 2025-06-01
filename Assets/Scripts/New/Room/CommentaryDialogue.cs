using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CommentaryDialogue : MonoBehaviour
{
    public float time = 2f;

    [SerializeField] private NPCConversation myConversation;

    public GameObject gameobject;
    public void StartDialogue()
    {
        ConversationManager.Instance.StartConversation(myConversation);
        StartCoroutine(Dialogue());
    }

    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(time);
        gameobject.SetActive(false);
    }
}
