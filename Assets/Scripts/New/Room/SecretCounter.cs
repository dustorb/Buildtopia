using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class SecretCounter : MonoBehaviour
{
    public TMP_Text text;
    public int secrets;

    public string scenename;
    public SaveAndLoadRoute SaveAndLoadRoute;

    void Awake()
    {
        text.text = "Загадок раскрыто: " + secrets;
        SaveAndLoadRoute.SaveLastRoute();
        StartCoroutine(ChangeScene());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SaveAndLoadRoute.ResetRoute();
        }

    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(scenename);
    }
}
