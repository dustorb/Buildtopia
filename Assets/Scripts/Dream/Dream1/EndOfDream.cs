using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfDream : MonoBehaviour
{
    //public string name;
    public WTransition transition;

    void Start()
    {
        StartCoroutine(EndOfVision());
    }

    IEnumerator EndOfVision()
    {
        yield return new WaitForSeconds(25f);
        transition.StartTrans();
        //SceneManager.LoadScene(name);
    }
}
