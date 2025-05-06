using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyLightOnComputer : MonoBehaviour
{
    public static DontDestroyLightOnComputer Instance;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}
