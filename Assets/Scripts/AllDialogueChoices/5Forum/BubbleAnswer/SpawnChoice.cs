using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChoice : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;
    //public string nameOfContent;

    void Start()
    {
        //ContentMessagerThread = GameObject.Find("ContentMessagerThread");
    }

    public void Choice()
    {
        ContentMessagerThread = GameObject.Find("ContentMessagerThread");
        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
