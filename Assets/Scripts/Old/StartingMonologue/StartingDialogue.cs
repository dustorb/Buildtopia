using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingDialogue : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    public GameObject canvas;

    public GameObject switchTowindows;
    public GameObject switchToboard;
    public GameObject switchTophone;
    public GameObject TurnOnComputer;
    public GameObject cursor;

    [Header("Visual Pointer")]
    public GameObject leftPoint;
    public GameObject rightPoint;
    //public GameObject logo;

    public bool PhoneCanRing;

    [Header("Telephone ring audiosource")]
    public AudioSource Telephone;
    public AudioClip Typesound;
    public AudioSource TextBeep;

    private void Start()
    {
        //TurnOnComputer = GameObject.Find("StartDialogue").GetComponent<StartingMonologueActivator>().TurnOnComputer;
    }
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
            canvas.SetActive(false);
            //StartCoroutine(EnableAllButtons());
            Destroy(GameObject.Find("StartLogoSetup"));
            PhoneCanRing = true;
            Telephone.Play();
        }
    }

    IEnumerator EnableAllButtons()
    {
        yield return new WaitForSeconds(3f);
        //switchToboard.SetActive(true);
        //switchTowindows.SetActive(true);
        //switchTophone.SetActive(true);
        //cursor.SetActive(true);
        //TurnOnComputer.SetActive(true);
        //leftPoint.SetActive(true);
        //rightPoint.SetActive(true);
        Destroy(GameObject.Find("StartLogoSetup"));


    }
}
