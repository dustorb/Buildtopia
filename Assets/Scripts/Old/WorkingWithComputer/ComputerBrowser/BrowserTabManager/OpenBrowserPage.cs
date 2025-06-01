using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBrowserPage : MonoBehaviour
{
    public BrowserTabManager tabManager;
    public string name;

 

    //pages
    public void OpenNewsPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenNewsPage();
        }
    }

    public void OpenSocialPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSocialPage();
        }
    }

    public void OpenWikiPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenWikiPage();
        }
    }

    public void OpenSecretPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSecretPage();
        }
    }

    public void OpenConspiracyPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenConspiracyPage();
        }
    }

    public void OpenSearchPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSearchPage();
        }
    }

    public void OpenSallyPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSallyPage();
        }
    }

    public void OpenVividDesignPage()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenVividDesignPage();
        }
    }

    //results

    public void OpenNewsResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenNewsResult();
        }
    }

    public void OpenSocialResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSocialResult();
        }
    }

    public void OpenWikiResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenWikiResult();
        }
    }

    public void OpenSecretResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenSecretResult();
        }
    }

    public void OpenConspiracyResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenConspiracyResult();
        }
    }

    public void OpenVivivLineResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenViviLineResult();
        }
    }

    public void OpenCoordResult()
    {
        tabManager = GameObject.Find(name).GetComponent<BrowserTabManager>();

        if (tabManager != null)
        {
            tabManager.OpenCoordResult();
        }
    }

}
