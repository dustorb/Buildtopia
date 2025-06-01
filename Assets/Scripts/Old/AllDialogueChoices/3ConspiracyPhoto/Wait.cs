using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{
    public CommentaryActivator dialogue;
    void Start()
    {
        //dialogue.gameObject.Find("CommentaryNoAnswerFromJohn").GetComponent<CommentaryActivator>();
    }
    public void Waiting()
    {
        StartCoroutine(WaitForMessage());
    }
    public IEnumerator WaitForMessage()
    {
        yield return new WaitForSeconds(2f);
        dialogue.StartingMonologue();
    }
}
