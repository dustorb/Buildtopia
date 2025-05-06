using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseFileForDecoding : MonoBehaviour
{
    [Header("filesToDecryptInFolder")]
    public GameObject file1;
    public GameObject file2;
    public GameObject file3;
    public GameObject file4;
    public GameObject file5;
    public GameObject file6;
    public GameObject file7;

    //[Header("filesToDecryptInFolder")]
    //public GameObject file1preview;
    //public GameObject file2preview;


    public void ChooseFile1()
    {
        file1.SetActive(true);
        file2.SetActive(false);
        file3.SetActive(false);
        file4.SetActive(false);
        file5.SetActive(false);
        file6.SetActive(false);
        file7.SetActive(false);
    }

    public void ChooseFile2()
    {
        file1.SetActive(false);
        file2.SetActive(true);
        file3.SetActive(false);
        file4.SetActive(false);
        file5.SetActive(false);
        file6.SetActive(false);
        file7.SetActive(false);
    }

    public void ChooseFile3()
    {
        file1.SetActive(false);
        file2.SetActive(false);
        file3.SetActive(true);
        file4.SetActive(false);
        file5.SetActive(false);
        file6.SetActive(false);
        file7.SetActive(false);
    }

    public void ChooseFile4()
    {
        file1.SetActive(false);
        file2.SetActive(false);
        file3.SetActive(false);
        file4.SetActive(true);
        file5.SetActive(false);
        file6.SetActive(false);
        file7.SetActive(false);
    }

    public void ChooseFile5()
    {
        file1.SetActive(false);
        file2.SetActive(false);
        file3.SetActive(false);
        file4.SetActive(false);
        file5.SetActive(true);
        file6.SetActive(false);
        file7.SetActive(false);
    }

    public void ChooseFile6()
    {
        file1.SetActive(false);
        file2.SetActive(false);
        file3.SetActive(false);
        file4.SetActive(false);
        file5.SetActive(false);
        file6.SetActive(true);
        file7.SetActive(false);
    }

    public void ChooseFile7()
    {
        file1.SetActive(false);
        file2.SetActive(false);
        file3.SetActive(false);
        file4.SetActive(false);
        file5.SetActive(false);
        file6.SetActive(false);
        file7.SetActive(true);
    }
}
