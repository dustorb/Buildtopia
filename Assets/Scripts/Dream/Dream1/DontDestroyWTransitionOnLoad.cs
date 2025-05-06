using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyWTransitionOnLoad : MonoBehaviour
{
    public static DontDestroyWTransitionOnLoad Instance;

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
