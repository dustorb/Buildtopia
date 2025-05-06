using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChoice3 : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;
    public GameObject BubbleChoice1;
    public GameObject BubbleChoice2;
    public GameObject BubbleChoice3;
    public GameObject BubbleChoice4;

    //public string nameOfContent;

    void Start()
    {
        //ContentMessagerThread = GameObject.Find("ContentMessagerThread");
    }

    public void Choice()
    {
        //ContentMessagerThread = GameObject.Find("ContentMessagerThread");
        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Choice1());
    }

    IEnumerator Choice1()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice1);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Choice2());
    }

    IEnumerator Choice2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice2);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Choice3());
    }

    IEnumerator Choice3()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice3);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Choice4());
    }

    IEnumerator Choice4()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice4);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        
    }
}
