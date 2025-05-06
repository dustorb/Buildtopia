using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    public SpawnQuestionsInForum SpawnQuestionsInForum;

    void Start()
    {
        SpawnQuestionsInForum = GameObject.Find("SpawnForumQuestions").GetComponent<SpawnQuestionsInForum>();
    }

    public void choice1()
    {
        if (SpawnQuestionsInForum != null)
        {
            SpawnQuestionsInForum.Choice1();
        }
    }

    public void choice2()
    {
        if (SpawnQuestionsInForum != null)
        {
            SpawnQuestionsInForum.Choice2();
        }
    }
}
