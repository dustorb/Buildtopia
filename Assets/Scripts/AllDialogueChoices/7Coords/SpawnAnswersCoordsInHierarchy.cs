using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnswersCoordsInHierarchy : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    public GameObject BubbleQuestion;
    public GameObject BubbleChoice;
    public GameObject BubbleChoice1;
    public GameObject BubbleChoice2;
    public GameObject BubbleChoice3;
    public GameObject BubbleChoice4;

    public void SpawnQuest()
    {
        GameObject message = (GameObject)Instantiate(BubbleQuestion);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }

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
        StartCoroutine(Answer3());
    }

    IEnumerator Answer3()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice3);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer4());
    }

    IEnumerator Answer4()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleChoice4);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
