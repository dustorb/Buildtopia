using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterPhone : MonoBehaviour
{
    [Header("TMP")]
    public TMP_InputField input;
    public GameObject phoneCanvas;
    public GameObject phoneCollider;
    public GameObject dialogueCanvas;
    public GameObject switchToComputer;

    [Header("DialogueNumber6666666")]
    public DialogueN1Activator dialogue;
   

    void Start()
    {
        //input = GetComponent<TMP_InputField>();
        input.characterLimit = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (input.text != null && input.text == "6666666" && Input.GetKeyDown(KeyCode.Return))
        {

            input.text = "";
            dialogue.StartDialogue();

        }

        else if (input.text == "" && Input.GetKeyDown(KeyCode.Return) && dialogueCanvas.active == false)
        {
            phoneCollider.SetActive(true);
            phoneCanvas.SetActive(false);
            switchToComputer.SetActive(true);
        }



    }
}
