using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBrowserPage : MonoBehaviour
{
    public GameObject tab;
    public string name;

    public void ClosePage()
    {
        tab = GameObject.Find(name);

        if (tab != null)
        {
            tab.SetActive(false);
        }
    }
}
