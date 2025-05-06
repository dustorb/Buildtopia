using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;

    //public GameObject Canvas;
    public GameObject choice1;
    public GameObject choice2;

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
       if (index == 3)
        {
            choice1.SetActive(true);
            choice2.SetActive(true);
        }
        else
        {
            foreach (char letter in sentences[index].ToCharArray())
            {
                //textHolder.color = new Color32(92, 33, 34, 255);
                textHolder.text += letter;
                yield return new WaitForSeconds(typeSpeed);
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
            //Canvas.SetActive(false);
        }
    }
}
