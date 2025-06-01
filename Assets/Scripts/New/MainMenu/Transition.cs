using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject TransCanvas;
    public float timeToTransition = 0.6f;
    public string scenename;
    public void StartTransition()
    {
        //TransCanvas = GameObject.Find("TransCanvas");
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        TransCanvas.SetActive(true);
        yield return new WaitForSeconds(timeToTransition);
        SceneManager.LoadScene(scenename);
    }
}
