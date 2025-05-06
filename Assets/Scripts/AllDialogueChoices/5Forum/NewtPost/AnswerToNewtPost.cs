using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerToNewtPost : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    //public string nameOfContent;
    
    public GameObject BubbleAnswer1;
    public GameObject BubbleAnswer2;
    public GameObject BubbleAnswer3;
    public GameObject BubbleAnswer4;

    public void StartAnswer()
    {
        StartCoroutine(Answer1());
    }

    IEnumerator Answer1()
    {
        yield return new WaitForSeconds(5f);
        GameObject message1 = (GameObject)Instantiate(BubbleAnswer1);
        message1.transform.SetParent(ContentMessagerThread.transform);
        message1.transform.localScale = new Vector3(1, 1, 1);
        message1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message1.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer2());
    }

    IEnumerator Answer2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message2 = (GameObject)Instantiate(BubbleAnswer2);
        message2.transform.SetParent(ContentMessagerThread.transform);
        message2.transform.localScale = new Vector3(1, 1, 1);
        message2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message2.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer3());
    }

    IEnumerator Answer3()
    {
        yield return new WaitForSeconds(2f);
        GameObject message3 = (GameObject)Instantiate(BubbleAnswer3);
        message3.transform.SetParent(ContentMessagerThread.transform);
        message3.transform.localScale = new Vector3(1, 1, 1);
        message3.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message3.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer4());
    }

    IEnumerator Answer4()
    {
        yield return new WaitForSeconds(5f);
        GameObject message4 = (GameObject)Instantiate(BubbleAnswer4);
        message4.transform.SetParent(ContentMessagerThread.transform);
        message4.transform.localScale = new Vector3(1, 1, 1);
        message4.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message4.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
