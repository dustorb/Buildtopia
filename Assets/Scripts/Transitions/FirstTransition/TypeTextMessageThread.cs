using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypeTextMessageThread : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public string[] sentences;
    public int index;
    public float typeSpeed = 0.02f;
    public GameObject TransitionKeyWord;

    public void StartDialog()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textHolder.text += letter;
            yield return new WaitForSeconds(typeSpeed);
            TransitionKeyWord.SetActive(true);
        }
    }


}
