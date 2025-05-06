using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAswersVivid : MonoBehaviour
{
    public SpawnAnswersToInfoVividLine SpawnAnswersToInfoVividLine;

    public void Spawn()
    {
        SpawnAnswersToInfoVividLine = GameObject.Find("SpawnAnswersToVivid").GetComponent<SpawnAnswersToInfoVividLine>();
        SpawnAnswersToInfoVividLine.SpawnAnswers();
    }
}
