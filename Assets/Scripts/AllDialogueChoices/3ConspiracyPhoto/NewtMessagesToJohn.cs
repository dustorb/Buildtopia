using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtMessagesToJohn : MonoBehaviour
{
    public GameObject BubbleMessage1;
    public GameObject BubbleMessage2;
    public GameObject BubbleMessage3;
    public GameObject ContentMessangerSocial;
    public GameObject CommentaryNoAnswerFromJohn;

    void Start()
    {
        ContentMessangerSocial = GameObject.Find("ContentMessangerSocial");
        CommentaryNoAnswerFromJohn = GameObject.Find("CommentaryNoAnswerFromJohn");
        //GameObject message = (GameObject)Instantiate(BubbleMessage1);
        //message.transform.SetParent(ContentMessangerSocial.transform);
        //message.transform.localScale = new Vector3(1, 1, 1);
        //message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //message.transform.rotation = ContentMessangerSocial.transform.rotation;

        //StartCoroutine(Message1());
    }

    public void NewtStartsTexting()
    {
        GameObject message = (GameObject)Instantiate(BubbleMessage1);
        message.transform.SetParent(ContentMessangerSocial.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessangerSocial.transform.rotation;

        //StartCoroutine(Message1());
    }

    IEnumerator Message1()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleMessage2);
        message.transform.SetParent(ContentMessangerSocial.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessangerSocial.transform.rotation;

        StartCoroutine(Message2());
    }

    IEnumerator Message2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message = (GameObject)Instantiate(BubbleMessage3);
        message.transform.SetParent(ContentMessangerSocial.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessangerSocial.transform.rotation;

        StartCoroutine(Dialogue1());
    }

    IEnumerator Dialogue1()
    {
        yield return new WaitForSeconds(1f);
        CommentaryNoAnswerFromJohn.GetComponent<CommentaryActivator>().StartingMonologue();
    }
}
