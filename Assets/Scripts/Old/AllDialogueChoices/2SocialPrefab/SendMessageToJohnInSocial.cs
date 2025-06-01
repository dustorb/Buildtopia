using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessageToJohnInSocial : MonoBehaviour
{
    [Header("Messages")]
    public GameObject ContentMessagerThread;
    public GameObject BubbleRight1;
    public GameObject BubbleRight2;
    public string nameOfContent;

    void Start()
    {
        ContentMessagerThread = GameObject.Find(nameOfContent);
    }

    public void Choice1()
    {
        GameObject message = (GameObject)Instantiate(BubbleRight1);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }

    public void Choice2()
    {
        GameObject message = (GameObject)Instantiate(BubbleRight2);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
