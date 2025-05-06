using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commentactivatorbeforealarm : MonoBehaviour
{
    public GameObject DialogueHolder;
    public Commentary dialogue;
    public GameObject block;

    public StartAlarmClockEvent StartAlarmClockEvent;
    
    void Start()
    {
        
        //turn = GameObject.Find("ComputerTurnOn");
    }

    public void StartingMonologue()
    {
        block.SetActive(true);
        StartAlarmClockEvent.StartAlarmEvent();
        //turn.SetActive(false);
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
        block.SetActive(false);
    }
}
