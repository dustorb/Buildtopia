using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingMonologueActivator : MonoBehaviour
{
    public GameObject DialogueHolder;
    public StartingDialogue dialogue;

    public GameObject switchTowindows;
    public GameObject switchToboard;
    public GameObject switchTophone;
    public GameObject TurnOnComputer;
    public GameObject cursor;

    [Header("Visual Pointer")]
    public GameObject leftPoint;
    public GameObject rightPoint;

    private void Start()
    {
        //TurnOnComputer = GameObject.Find("ComputerTurnOn");
        leftPoint.SetActive(false);
        rightPoint.SetActive(false);
        cursor.SetActive(false);
        switchToboard.SetActive(false);
        switchTowindows.SetActive(false);
        switchTophone.SetActive(false);
        TurnOnComputer.SetActive(false);
    }

    void StartingMonologue()
    {
        StartCoroutine(Monologue());
    }

    IEnumerator Monologue()
    {
        yield return new WaitForSeconds(3f);
        DialogueHolder.SetActive(true);
        Talking();
    }
    void Talking()
    {
        dialogue.enabled = true;
        dialogue.StartDialog();
    }
}
