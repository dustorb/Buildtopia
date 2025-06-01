using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DecodingChooseFilePhoto : MonoBehaviour
{
    public GameObject file1;
    public GameObject file2;
    public GameObject file3;
    public GameObject file4;
    public GameObject file5;
    public GameObject file6;
    public GameObject file7;
    public GameObject TextDecryptArea;
    private FileCode FileCode;
    public string code;
    public GameObject Coords;

    void Start()
    {

    }

    public void LoadFile()
    {

        if (file1.activeSelf)
        {
            code = file1.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file2.activeSelf)
        {
            code = file2.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file3.activeSelf)
        {
            code = file3.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file4.activeSelf)
        {
            code = file4.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file5.activeSelf)
        {
            code = file5.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file6.activeSelf)
        {
            code = file6.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
        }
        else if (file7.activeSelf)
        {
            code = file7.GetComponent<FileCode>().code;
            TextDecryptArea.GetComponent<TMP_Text>().text = code;
            Coords.SetActive(true);
        }
    }
}


