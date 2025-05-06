using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueChoicesManager : MonoBehaviour
{
    [Header("DialogueHolder")]
    public GameObject DialogueHolder;
    [Header("Dialogue1")]
    public Dialogue dialogue1;
    public DialogueActivator activator1;
    [Header("Choices1")]
    public GameObject choice1;
    public GameObject choice2;

    public void Choice1()
    {
        DialogueHolder.SetActive(false);
        dialogue1.enabled = false;
        activator1.enabled = false;
        choice1.SetActive(false);
        choice2.SetActive(false);
    }

    public void Choice2()
    {
        DialogueHolder.SetActive(false);
        dialogue1.enabled = false;
        activator1.enabled = false;
        choice1.SetActive(false);
        choice2.SetActive(false);
    }
}
