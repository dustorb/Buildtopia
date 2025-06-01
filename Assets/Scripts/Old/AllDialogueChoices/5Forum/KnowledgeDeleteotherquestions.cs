using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowledgeDeleteotherquestions : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;

    public void Knowledge()
    {
        question1 = GameObject.Find("BubbleChoiceQuestionForum1(Clone)");
        question2 = GameObject.Find("BubbleChoiceQuestionForum2(Clone)");

        if (question1 != null)
        {
            
            Destroy(GameObject.Find("BubbleChoiceQuestionForum1(Clone)"));
        }

        if (question2 != null)
        {

            Destroy(GameObject.Find("BubbleChoiceQuestionForum2(Clone)"));
        }
    }
}
