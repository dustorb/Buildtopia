using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceInMessanger : MonoBehaviour
{
    [Header("Messages")]
    public GameObject ContentMessagerThread;
    public GameObject BubbleRight;
    public GameObject BubbleRightPhoto;
    public TextChoicesChanger textChoicesChanger;
    public string nameOfContent;

    void Start()
    {
        ContentMessagerThread = GameObject.Find(nameOfContent);
        textChoicesChanger = FindObjectOfType<TextChoicesChanger>();
    }
   
    public void Choice1()
    {
        GameObject message = (GameObject)Instantiate(BubbleRight);
        message.transform.SetParent(ContentMessagerThread.transform);
        //message.transform.localScale = Vector2.one;
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;

        //message count

        textChoicesChanger.i++;
    }

    public void Choice2()
    {
        GameObject message = (GameObject)Instantiate(BubbleRightPhoto);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = Vector2.one;
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
