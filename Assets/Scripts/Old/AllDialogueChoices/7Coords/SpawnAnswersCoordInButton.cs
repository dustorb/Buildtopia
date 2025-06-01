using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnswersCoordInButton : MonoBehaviour
{
    public SpawnAnswersCoordsInHierarchy SpawnAnswersCoordsInHierarchy;

    public void Spawn()
    {
        SpawnAnswersCoordsInHierarchy = GameObject.Find("SpawnAnswersCoords").GetComponent<SpawnAnswersCoordsInHierarchy>();
        SpawnAnswersCoordsInHierarchy.SpawnAnswers();
    }

    public void SpawnQuestion()
    {
        SpawnAnswersCoordsInHierarchy = GameObject.Find("SpawnAnswersCoords").GetComponent<SpawnAnswersCoordsInHierarchy>();
        SpawnAnswersCoordsInHierarchy.SpawnQuest();
    }
}
