using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class CommentaryYoutubeForum : MonoBehaviour
{
    public int youtube;
    public int forum;

    public SecretCounter SecretCounter;

    [SerializeField] private NPCConversation myConversation1;

    public void IncreaseYoutubeCommentaryCounter()
    {
        youtube += 1;
        if (youtube == 3)
        {
            SecretCounter.secrets += 1;
            StartCoroutine(Youtube());
            
        }
    }

    public void IncreaseForumCommentaryCounter()
    {
        forum += 1;
        if (forum == 2)
        {
            SecretCounter.secrets += 1;
            StartCoroutine(Forum());
            
        }
    }

    IEnumerator Youtube()
    {
        yield return new WaitForSeconds(3f);
        ConversationManager.Instance.StartConversation(myConversation1);
    }

    IEnumerator Forum()
    {
        yield return new WaitForSeconds(3f);
        ConversationManager.Instance.StartConversation(myConversation1);
    }
}
