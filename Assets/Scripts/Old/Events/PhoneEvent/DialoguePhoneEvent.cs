using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialoguePhoneEvent : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    //public GameObject canvas;
    //public PhoneEvent phoneEvent;
    //public GameObject switchTowindows;
    //public GameObject switchToboard;
    //public GameObject switchTophone;

    [Header("Choice1")]
    public GameObject Choice1;

    [Header("TypeSound")]
    public AudioClip Typesound;
    public AudioSource TextBeep;

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
            //canvas.SetActive(false);
            ////phoneEvent.PickUpThePhone = false;
            //switchToboard.SetActive(true);
            //switchTowindows.SetActive(true);
            //switchTophone.SetActive(true);
            Choice1.SetActive(true);
        }
    }
}
