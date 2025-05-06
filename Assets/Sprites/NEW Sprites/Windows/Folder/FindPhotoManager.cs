using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPhotoManager : MonoBehaviour
{
    public PhotoManager manager;
    public string name;
    // Start is called before the first frame update
    public void OpenPhoto1FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto1();
        }
    }

    public void OpenPhoto2FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto2();
        }
    }

    public void OpenPhoto3FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto3();
        }
    }

    public void OpenPhoto4FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto4();
        }
    }

    public void OpenPhoto5FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto5();
        }
    }

    public void OpenPhoto6FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto6();
        }
    }

    public void OpenPhoto7FromManager()
    {
        manager = GameObject.Find(name).GetComponent<PhotoManager>();
        if (manager != null)
        {
            manager.OpenPhoto7();
        }
    }
}
