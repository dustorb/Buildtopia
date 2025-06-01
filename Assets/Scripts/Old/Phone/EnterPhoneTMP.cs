using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterPhoneTMP : MonoBehaviour
{
    public TMP_Text numberText;
    public string numberString;

    [Header("colliders")]
    public GameObject switchToComputer;
    public GameObject numbersCollider;

    [Header("dialogue for 525 3376")]
    public DialogueN1Activator dialogueActivatorAfter;
    public DialogueN2Activator dialogueActivatorBefore;



    [Header("dialogue for wrong number")]
    public WrongNumberActivator WrongNumberActivator;


    [Header("interactive object on jacob PG")]
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    //public GameObject obj4;

    [Header("JohnDialogue")]
    public bool foundSymbol;
    public bool jacobPage;

    public bool thirdscene;

    // Start is called before the first frame update
    void Start()
    {
        numberText.text = "";
        numberString = "";
        foundSymbol = false;
        jacobPage = false;
        if (thirdscene == true)
        {
            foundSymbol = true;
            jacobPage = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        numberString = numberText.text;

        if (numberString.Length == 3)
        {
            numberText.text += " ";
            numberString = numberText.text;
        }
        if (numberString.Length == 8)
        {
            if (numberString == "525 3376")
            {
                if (foundSymbol == false && jacobPage == false         )
                {
                    numbersCollider.SetActive(false);
                    switchToComputer.SetActive(false);
                    dialogueActivatorBefore.StartDialogue();
                    numberText.text = "";
                }
                else if (foundSymbol == true && jacobPage == true)
                {
                    numbersCollider.SetActive(false);
                    switchToComputer.SetActive(false);
                    dialogueActivatorAfter.StartDialogue();
                    numberText.text = "";
                }
                else if (foundSymbol == true && jacobPage == false)
                {
                    numbersCollider.SetActive(false);
                    switchToComputer.SetActive(false);
                    dialogueActivatorAfter.StartDialogue();
                    numberText.text = "";
                    obj1.SetActive(true);
                    obj2.SetActive(true);
                    obj3.SetActive(true);
                    jacobPage = true;
                }
                else
                {
                    numbersCollider.SetActive(false);
                    switchToComputer.SetActive(false);
                    WrongNumberActivator.StartDialogue();
                    numberText.text = "";
                }
            }
            //if (numberString != null && numberString == "525 3376" && foundSymbol == true && jacobPage == false)
            //{
            //    numbersCollider.SetActive(false);
            //    switchToComputer.SetActive(false);
            //    dialogueActivatorAfter.StartDialogue();
            //    numberText.text = "";
            //    //obj1.SetActive(true);
            //    //obj2.SetActive(true);
            //    //obj3.SetActive(true);
            //    //obj4.SetActive(true);
            //    jacobPage = true;
            //}
            //else if (numberString != null && numberString == "525 3376" && foundSymbol == true && jacobPage == true)
            //{
            //    numbersCollider.SetActive(false);
            //    switchToComputer.SetActive(false);
            //    dialogueActivatorAfter.StartDialogue();
            //    numberText.text = "";
            //}
            //else if (numberString != null && numberString == "525 3376" && foundSymbol == false && jacobPage == false)
            //{
            //    numbersCollider.SetActive(false);
            //    switchToComputer.SetActive(false);
            //    dialogueActivatorBefore.StartDialogue();
            //    numberText.text = "";
            //}
            else
            {
                numbersCollider.SetActive(false);
                switchToComputer.SetActive(false);
                WrongNumberActivator.StartDialogue();
                numberText.text = "";
            }

            //switch (numberString)
            //{
            //    case "525 3376":
            //        if (foundSymbol == true && jacobPage == false)
            //        {
            //            numbersCollider.SetActive(false);
            //            switchToComputer.SetActive(false);
            //            dialogueActivatorAfter.StartDialogue();
            //            numberText.text = "";
            //            obj1.SetActive(true);
            //            jacobPage = true;

            //        }
            //        else if (foundSymbol == true && jacobPage == true)
            //        {
            //            numbersCollider.SetActive(false);
            //            switchToComputer.SetActive(false);
            //            dialogueActivatorAfter.StartDialogue();
            //            numberText.text = "";

            //        }
            //        else if (foundSymbol == false && jacobPage == false)
            //        {
            //            numbersCollider.SetActive(false);
            //            switchToComputer.SetActive(false);
            //            dialogueActivatorBefore.StartDialogue();
            //            numberText.text = "";

            //        }
            //        break;
            //    default:
            //        numbersCollider.SetActive(false);
            //        switchToComputer.SetActive(false);
            //        WrongNumberActivator.StartDialogue();
            //        numberText.text = "";
            //        break;

            //}
        }
        else if (numberString.Length > 8)
        {
            numbersCollider.SetActive(false);
            switchToComputer.SetActive(false);
            WrongNumberActivator.StartDialogue();
            numberText.text = "";
        }
    }
}
