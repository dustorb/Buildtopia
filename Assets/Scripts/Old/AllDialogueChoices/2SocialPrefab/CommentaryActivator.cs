using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentaryActivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public Commentary dialogue;

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
