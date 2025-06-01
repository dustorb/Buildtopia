using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SkipTheDialogue : MonoBehaviour
{
    public GameObject SkipButton;

    public void ShowButtonSkip()
    {
        SkipButton.SetActive(true);
        StartCoroutine(Dialogue());
    }

    public void EndConversation()
    {
        ConversationManager.Instance.EndConversation();
        SkipButton.SetActive(false);
    }

    IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(4f);
        SkipButton.SetActive(false);

    }

}
