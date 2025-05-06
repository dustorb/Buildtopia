using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FindKeyWord : MonoBehaviour
{
    //keyword for transition

    public GameObject keybutton;
    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;
    public CinemachineVirtualCamera vc;
    public GameObject BubbleLeftTyping;
    public GameObject BubbleLeft1;
    public GameObject BubbleLeft2;
    public GameObject BubbleLeft3;
    public GameObject BubbleRightWithPicture;
    public GameObject WindowsToComputerSwitch1;
    public GameObject WindowsToComputerSwitch2;

    public void FindKeyWordForTransition()
    {
        keybutton.SetActive(false);
        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }

    public void ShareYourDiscovery()
    {
        vc.m_Priority = 25;
        GameObject message = (GameObject)Instantiate(BubbleRightWithPicture);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(WaitBeforeReceive1());
    }

    IEnumerator WaitBeforeReceive1()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleLeft1);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(WaitBeforeReceive2());
    }

    IEnumerator WaitBeforeReceive2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleLeft2);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(WaitBeforeReceive3());
    }

    IEnumerator WaitBeforeReceive3()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleLeft3);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(WaitBeforeReceive4()); 
    }

    IEnumerator WaitBeforeReceive4()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleLeftTyping);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
