using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnQuestionVividLogo : MonoBehaviour
{
    public GameObject QuestionSpawn;
    
    public void FindSpawn()
    {
        QuestionSpawn = GameObject.Find("SpawnQuestionsVivid");
        QuestionSpawn.GetComponent<SpawnChoice2>().Choice();
    }

}
