using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtcommentAfterv2 : MonoBehaviour
{
    public GameObject newtcomment;

    public void FindComment()
    {
        newtcomment = GameObject.Find("NewtCommentAfterV2");
        newtcomment.GetComponent<Commentactivatorbeforealarm>().StartingMonologue();
    }
}
