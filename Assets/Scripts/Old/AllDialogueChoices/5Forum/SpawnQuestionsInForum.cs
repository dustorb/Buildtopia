using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnQuestionsInForum : MonoBehaviour
{
    public GameObject ContentMessagerThread;
    public string nameOfContent;
    public bool question1;
    public bool question2;
    public GameObject BubbleChoiceQuestionForum1;
    public GameObject BubbleChoiceQuestionForum2;
    public GameObject BubbleAnswer1;
    public GameObject BubbleAnswer2;
    public GameObject BubbleAnswer3;
    public GameObject BubbleAnswer4;
    public GameObject BubbleAnswer5;
    //public GameObject BubbleAnswer6;
    public GameObject question1asked;
    public GameObject question2asked;
    public GameObject NoteIncapable;

    public GameObject Knowledge;
    public bool KnowledgeButton;
    public GameObject KnowledgeBubble;

    void Start()
    {
        //question1asked = GameObject.Find("BubbleChoiceQuestionForum1(Clone)");
        //question2asked = GameObject.Find("BubbleChoiceQuestionForum2(Clone)");

        //if (question1asked != null && question2asked == null)
        //{
        //    question1 = true;
        //}
        //else if (question2asked != null && question1asked == null)
        //{
        //    question2 = true;
        //}
    }

    public void Question1()
    {
        //question1 = true;
        GameObject message8 = (GameObject)Instantiate(BubbleChoiceQuestionForum1);
        message8.transform.SetParent(ContentMessagerThread.transform);
        message8.transform.localScale = new Vector3(1, 1, 1);
        message8.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message8.transform.rotation = ContentMessagerThread.transform.rotation;
    }

    public void Question2()
    {
        //question2 = true;
        GameObject message4 = (GameObject)Instantiate(BubbleChoiceQuestionForum2);
        message4.transform.SetParent(ContentMessagerThread.transform);
        message4.transform.localScale = new Vector3(1, 1, 1);
        message4.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message4.transform.rotation = ContentMessagerThread.transform.rotation;
    }

    public void Choice1()
    {
        //question1asked = GameObject.Find("BubbleChoiceQuestionForum1(Clone)");
        //question2asked = GameObject.Find("BubbleChoiceQuestionForum2(Clone)");

        //if (question1asked != null && question2asked == null)
        //{
        //    question1 = true;
        //}
        //else if (question2asked != null && question1asked == null)
        //{
        //    question2 = true;
        //}
        //question1 = true;
        NoteIncapable.SetActive(true);

        question2asked = GameObject.Find("BubbleChoiceQuestionForum2(Clone)");

        Knowledge = GameObject.Find("ShareYourKnowledgeVision1(Clone)");

        if (question2asked != null)
        {
            question2 = true;
        }

        if (Knowledge != null)
        {
            KnowledgeButton = true;
            Destroy(GameObject.Find("ShareYourKnowledgeVision1(Clone)"));
        }


        if (question2)
        {
            Destroy(GameObject.Find("BubbleChoiceQuestionForum2(Clone)"));

            StartCoroutine(Answer1());
        }
        else if (!question2)
        {
            StartCoroutine(Answer11());
        }

    }

    IEnumerator Answer1()
    {
        yield return new WaitForSeconds(2f);
        GameObject message1 = (GameObject)Instantiate(BubbleAnswer1);
        message1.transform.SetParent(ContentMessagerThread.transform);
        message1.transform.localScale = new Vector3(1, 1, 1);
        message1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message1.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer2());
        //question1 = false;
        //question2 = false;
    }

    IEnumerator Answer2()
    {
        yield return new WaitForSeconds(2f);
        GameObject message2 = (GameObject)Instantiate(BubbleAnswer2);
        message2.transform.SetParent(ContentMessagerThread.transform);
        message2.transform.localScale = new Vector3(1, 1, 1);
        message2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message2.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer3());
    }

    IEnumerator Answer3()
    {
        yield return new WaitForSeconds(2f);
        GameObject message3 = (GameObject)Instantiate(BubbleAnswer3);
        message3.transform.SetParent(ContentMessagerThread.transform);
        message3.transform.localScale = new Vector3(1, 1, 1);
        message3.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message3.transform.rotation = ContentMessagerThread.transform.rotation;

        GameObject message4 = (GameObject)Instantiate(BubbleChoiceQuestionForum2);
        message4.transform.SetParent(ContentMessagerThread.transform);
        message4.transform.localScale = new Vector3(1, 1, 1);
        message4.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message4.transform.rotation = ContentMessagerThread.transform.rotation;

        if (KnowledgeButton)
        {
            GameObject knowledge1 = (GameObject)Instantiate(KnowledgeBubble);
            knowledge1.transform.SetParent(ContentMessagerThread.transform);
            knowledge1.transform.localScale = new Vector3(1, 1, 1);
            knowledge1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            knowledge1.transform.rotation = ContentMessagerThread.transform.rotation;
        }
    }
    
    IEnumerator Answer11()
    {
        yield return new WaitForSeconds(2f);
        GameObject message1 = (GameObject)Instantiate(BubbleAnswer1);
        message1.transform.SetParent(ContentMessagerThread.transform);
        message1.transform.localScale = new Vector3(1, 1, 1);
        message1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message1.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer22());
        //question1 = false;
        //question2 = false;
    }

    IEnumerator Answer22()
    {
        yield return new WaitForSeconds(2f);
        GameObject message2 = (GameObject)Instantiate(BubbleAnswer2);
        message2.transform.SetParent(ContentMessagerThread.transform);
        message2.transform.localScale = new Vector3(1, 1, 1);
        message2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message2.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer33());
    }

    IEnumerator Answer33()
    {
        yield return new WaitForSeconds(2f);
        GameObject message3 = (GameObject)Instantiate(BubbleAnswer3);
        message3.transform.SetParent(ContentMessagerThread.transform);
        message3.transform.localScale = new Vector3(1, 1, 1);
        message3.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message3.transform.rotation = ContentMessagerThread.transform.rotation;

        if (KnowledgeButton)
        {
            //Destroy(GameObject.Find("ShareYourKnowledgeVision1(Clone)"));
            GameObject knowledge2 = (GameObject)Instantiate(KnowledgeBubble);
            knowledge2.transform.SetParent(ContentMessagerThread.transform);
            knowledge2.transform.localScale = new Vector3(1, 1, 1);
            knowledge2.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            knowledge2.transform.rotation = ContentMessagerThread.transform.rotation;
        }
    }

    public void Choice2()
    {
        //question1asked = GameObject.Find("BubbleChoiceQuestionForum1(Clone)");
        //question2asked = GameObject.Find("BubbleChoiceQuestionForum2(Clone)");

        //if (question1asked != null && question2asked == null)
        //{
        //    question1 = true;
        //}
        //else if (question2asked != null && question1asked == null)
        //{
        //    question2 = true;
        //}
        //question2 = true;

        question1asked = GameObject.Find("BubbleChoiceQuestionForum1(Clone)");

        Knowledge = GameObject.Find("ShareYourKnowledgeVision1(Clone)");

        if (question1asked != null)
        {
            question1 = true;
        }

        if (Knowledge != null)
        {
            KnowledgeButton = true;
            Destroy(GameObject.Find("ShareYourKnowledgeVision1(Clone)"));
        }

        if (question1)
        {
            Destroy(GameObject.Find("BubbleChoiceQuestionForum1(Clone)"));
            StartCoroutine(Answer4());
        }
        else if (!question1)
        {
            StartCoroutine(Answer44());
        }

    }

    IEnumerator Answer4()
    {
        yield return new WaitForSeconds(2f);
        GameObject message5 = (GameObject)Instantiate(BubbleAnswer4);
        message5.transform.SetParent(ContentMessagerThread.transform);
        message5.transform.localScale = new Vector3(1, 1, 1);
        message5.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message5.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer5());
        //question1 = false;
        //question2 = false;
    }

    IEnumerator Answer5()
    {
        yield return new WaitForSeconds(2f);
        GameObject message6 = (GameObject)Instantiate(BubbleAnswer5);
        message6.transform.SetParent(ContentMessagerThread.transform);
        message6.transform.localScale = new Vector3(1, 1, 1);
        message6.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message6.transform.rotation = ContentMessagerThread.transform.rotation;

        GameObject message8 = (GameObject)Instantiate(BubbleChoiceQuestionForum1);
        message8.transform.SetParent(ContentMessagerThread.transform);
        message8.transform.localScale = new Vector3(1, 1, 1);
        message8.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message8.transform.rotation = ContentMessagerThread.transform.rotation;

        if (KnowledgeButton)
        {
            GameObject knowledge1 = (GameObject)Instantiate(KnowledgeBubble);
            knowledge1.transform.SetParent(ContentMessagerThread.transform);
            knowledge1.transform.localScale = new Vector3(1, 1, 1);
            knowledge1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            knowledge1.transform.rotation = ContentMessagerThread.transform.rotation;
        }

    }

    IEnumerator Answer44()
    {
        yield return new WaitForSeconds(2f);
        GameObject message5 = (GameObject)Instantiate(BubbleAnswer4);
        message5.transform.SetParent(ContentMessagerThread.transform);
        message5.transform.localScale = new Vector3(1, 1, 1);
        message5.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message5.transform.rotation = ContentMessagerThread.transform.rotation;
        StartCoroutine(Answer55());
        //question1 = false;
        //question2 = false;
    }

    IEnumerator Answer55()
    {
        yield return new WaitForSeconds(2f);
        GameObject message6 = (GameObject)Instantiate(BubbleAnswer5);
        message6.transform.SetParent(ContentMessagerThread.transform);
        message6.transform.localScale = new Vector3(1, 1, 1);
        message6.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message6.transform.rotation = ContentMessagerThread.transform.rotation;

        if (KnowledgeButton)
        {
            GameObject knowledge1 = (GameObject)Instantiate(KnowledgeBubble);
            knowledge1.transform.SetParent(ContentMessagerThread.transform);
            knowledge1.transform.localScale = new Vector3(1, 1, 1);
            knowledge1.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            knowledge1.transform.rotation = ContentMessagerThread.transform.rotation;
        }

    }
}
