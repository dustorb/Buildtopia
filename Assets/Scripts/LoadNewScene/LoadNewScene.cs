using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public string name;

    public void ChangeScene()
    {
        SceneManager.LoadScene(name);
    }
}
