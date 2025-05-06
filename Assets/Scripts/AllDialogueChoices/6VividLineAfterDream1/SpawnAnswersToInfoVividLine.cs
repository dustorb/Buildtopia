using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnswersToInfoVividLine : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;
    public GameObject BubbleChoice1;
    public GameObject BubbleChoice2;

    public void SpawnAnswers()
    {
        //ContentMessagerThread = GameObject.Find("ContentMessagerThread");
        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer1());
    }

    IEnumerator Answer1()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice1);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer2());
    }

    IEnumerator Answer2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice2);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
