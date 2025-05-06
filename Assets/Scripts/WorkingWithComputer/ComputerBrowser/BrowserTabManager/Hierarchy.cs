using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hierarchy : MonoBehaviour
{
    public ChangeHierarchy window;
    public string name;

    void Start()
    {
        window = GameObject.Find(name).GetComponent<ChangeHierarchy>();

    }

    public void MakeHigher()
    {
        window.HigherInHierarchy();
    }

    public void MakeLower()
    {
        window.LowerInHierarchy();
    }
}
