using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentafteralarmActivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public Commentaryafteralarm dialogue;

    public void StartingMonologue()
    {
        StartCoroutine(Monologue());
    }

    IEnumerator Monologue()
    {
        yield return new WaitForSeconds(1f);
        DialogueHolder.SetActive(true);
        Talking();
    }
    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
