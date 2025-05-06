using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WTransition : MonoBehaviour
{
    public GameObject transition;
    public Animator animator;

    //new comments in chat
    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;
    //public GameObject BubbleChoice2;
    //public GameObject BubbleChoice3;

    //change the music to main theme
    public GameObject MusicChange;

    public void StartTrans()
    {
        transition.SetActive(true);
        animator.Play("PlayW");

        ContentMessagerThread = GameObject.Find("ContentMessagerThread");
        MusicChange = GameObject.Find("SecondMusicTransition");

        MusicChange.GetComponent<MusicChange>().ChangeClip();

        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessagerThread.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessagerThread.transform.rotation;

        //GameObject message2 = (GameObject)Instantiate(BubbleChoice2);
        //message2.transform.SetParent(ContentMessagerThread.transform);
        //message2.transform.localScale = new Vector3(1, 1, 1);
        //message2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //message2.transform.rotation = ContentMessagerThread.transform.rotation;

        //GameObject message3 = (GameObject)Instantiate(BubbleChoice3);
        //message3.transform.SetParent(ContentMessagerThread.transform);
        //message3.transform.localScale = new Vector3(1, 1, 1);
        //message3.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //message3.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
