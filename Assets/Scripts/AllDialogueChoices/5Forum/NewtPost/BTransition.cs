using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTransition : MonoBehaviour
{
    public GameObject transition;
    public Animator animator;
    public CommentaryActivator commentary;

    public GameObject ContentMessagerThread;
    public GameObject BubbleChoice;

    public GameObject MusicChange;

    public GameObject vp1;
    public GameObject vp2;

    public void StartTrans()
    {
        vp1.SetActive(false);
        vp2.SetActive(false);
        transition.SetActive(true);
        animator.Play("Play");
        StartCoroutine(MonologueAfterDream1());
    }

    IEnumerator MonologueAfterDream1()
    {
        yield return new WaitForSeconds(30f);
        //MusicChange.GetComponent<MusicChange>().ChangeClip();
        commentary.StartingMonologue();


        //GameObject message = (GameObject)Instantiate(BubbleChoice);
        //message.transform.SetParent(ContentMessagerThread.transform);
        //message.transform.localScale = new Vector3(1, 1, 1);
        //message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //message.transform.rotation = ContentMessagerThread.transform.rotation;
    }
}
