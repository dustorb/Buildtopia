using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CommentaryMinigame : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    public GameObject canvas;

    [Header("TypeSound")]
    public AudioClip Typesound;
    public AudioSource TextBeep;

    [Header("fintrans")]
    public TransitionFromfindreamtofinroom trans;
    public GameObject EightMusicTransition;


    public void StartDialog()
    {
        StartCoroutine(Type());
        trans = GameObject.Find("FinTranstoFinRoom").GetComponent<TransitionFromfindreamtofinroom>();
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

            EightMusicTransition = GameObject.Find("EightMusicTransition");
            EightMusicTransition.GetComponent<MusicChange>().ChangeClip();
            trans.Trans();
            
        }
    }
}
