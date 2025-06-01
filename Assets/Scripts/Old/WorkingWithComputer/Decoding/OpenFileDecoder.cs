using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFileDecoder : MonoBehaviour
{
    public ChooseFileForDecoding choose;

    // Start is called before the first frame update
    public void OpenFile1()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile1();
    }

    public void OpenFile2()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile2();
    }

    public void OpenFile3()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile3();
    }

    public void OpenFile4()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile4();
    }

    public void OpenFile5()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile5();
    }

    public void OpenFile6()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile6();
    }

    public void OpenFile7()
    {
        choose = GameObject.Find("ChooseFileDecoderDecrypt").GetComponent<ChooseFileForDecoding>();
        choose.ChooseFile7();
    }
}
