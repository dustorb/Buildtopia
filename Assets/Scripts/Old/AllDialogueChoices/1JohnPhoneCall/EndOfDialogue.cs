using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndOfDialogue : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    public GameObject canvas;
    public PhoneEvent phoneEvent;
    public GameObject switchTowindows;
    public GameObject switchToboard;
    public GameObject switchTophone;
    public GameObject TurnOnComputer;
    [Header("Visual Pointer")]
    public GameObject leftPoint;
    public GameObject rightPoint;

    [Header("TypeSound")]
    public AudioClip Typesound;
    public AudioSource TextBeep;

    //public bool IsThereChoiceInEnd;
    //public GameObject Choice;



    public void StartDialog()
    {
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {

        if (textHolder.text == sentences[index])
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                NextSentence();
            }
        }

        
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {

            textHolder.text += letter;
            TextBeep.PlayOneShot(Typesound);
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textHolder.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textHolder.text = "";
            index = 0;
            this.enabled = false;
            //phoneEvent.PickUpThePhone = false;
            StartCoroutine(EnableAllButtons());
            //if (IsThereChoiceInEnd)
            //{
            //    Choice.SetActive(true);
            //}
            //if (!IsThereChoiceInEnd)
            //{
            //    canvas.SetActive(false);
            //    //phoneEvent.PickUpThePhone = false;
            //    switchToboard.SetActive(true);
            //    switchTowindows.SetActive(true);
            //    switchTophone.SetActive(true);
            //}
        }
    }

    IEnumerator EnableAllButtons()
    {
        yield return new WaitForSeconds(1f);
       
        switchToboard.SetActive(true);
        switchTowindows.SetActive(true);
        switchTophone.SetActive(true);
        TurnOnComputer.SetActive(true);
        leftPoint.SetActive(true);
        leftPoint.GetComponent<Animator>().Play("Appear");
        rightPoint.SetActive(true);
        canvas.SetActive(false);
        
    }
    
}
