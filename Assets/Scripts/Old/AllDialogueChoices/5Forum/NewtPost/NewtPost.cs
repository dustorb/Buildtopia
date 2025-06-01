using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtPost : MonoBehaviour
{
    public AnswerToNewtPost AnswerToNewtPost;

    // Start is called before the first frame update
    public void StartText()
    {
        AnswerToNewtPost = GameObject.Find("NewtPostAnswerVision1").GetComponent<AnswerToNewtPost>();
        AnswerToNewtPost.StartAnswer();
    }


}
