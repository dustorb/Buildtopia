using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueN1 : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    public GameObject canvas;

    [Header("TMP")]
    public GameObject keyword;

    [Header("PhoneCollider")]
    public GameObject phoneCollider;
    public GameObject switchToComputer;

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
        //if (canvas.active = false)
        //{
        //    phoneCollider.SetActive(true);
        //}
    }

    IEnumerator Type()
    {
        if (index == 1)
        {
            foreach (char letter in sentences[index].ToCharArray())
            {
                //textHolder.color = new Color32(92, 33, 34, 255);
                textHolder.text += letter;
                TextBeep.PlayOneShot(Typesound);
                yield return new WaitForSeconds(typeSpeed);
            }
            keyword.SetActive(true);
        }
        else
        {
            foreach (char letter in sentences[index].ToCharArray())
            {
                //textHolder.color = new Color32(92, 33, 34, 255);
                textHolder.text += letter;
                TextBeep.PlayOneShot(Typesound);
                yield return new WaitForSeconds(typeSpeed);
            }

            if (keyword.active == true)
            {
                keyword.SetActive(false);
            }
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
            phoneCollider.SetActive(true);
            switchToComputer.SetActive(true);
            canvas.SetActive(false);
            
        }
    }
}
