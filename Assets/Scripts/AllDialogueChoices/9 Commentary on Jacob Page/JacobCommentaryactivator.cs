using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacobCommentaryactivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public JacobpageCommentary dialogue;
    public GameObject com1;
    public GameObject com2;

    public void StartingMonologue()
    {
        com1.SetActive(false);
        com2.SetActive(false);
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
