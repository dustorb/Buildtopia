using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionB2 : MonoBehaviour
{
    public GameObject transition;
    public Animator animator;
    //public CommentaryActivator commentary;

    //public GameObject ContentMessagerThread;
    //public GameObject BubbleChoice;

    public void StartTrans()
    {
        transition.SetActive(true);
        animator.Play("Play");
        //StartCoroutine(MonologueAfterDream1());
    }

    //IEnumerator MonologueAfterDream1()
    //{
    //    yield return new WaitForSeconds(30f);
    //    commentary.StartingMonologue();

    //    GameObject message = (GameObject)Instantiate(BubbleChoice);
    //    message.transform.SetParent(ContentMessagerThread.transform);
    //    message.transform.localScale = new Vector3(1, 1, 1);
    //    message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    message.transform.rotation = ContentMessagerThread.transform.rotation;
    //}
}
