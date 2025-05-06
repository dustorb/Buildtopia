using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrowserTabManager : MonoBehaviour
{
    [Header("windows")]
    public GameObject SocialWindow;
    public GameObject WikiWindow;
    public GameObject SecretWindow;
    public GameObject NewsWindow;
    public GameObject ConspiracyWindow;
    public GameObject SearchWindow;
    public GameObject VividDesignWindow;
    public GameObject SallyWindow;
    [Header("results")]
    public GameObject scrollViewContent;
    public GameObject SocialResult;
    public GameObject WikiResult;
    public GameObject SecretResult;
    public GameObject NewsResult;
    public GameObject ConspiracyResult;
    public GameObject VividLineResult;
    public GameObject CoordResult;



    public void OpenNewsPage()
    {
        NewsWindow.SetActive(true);
    }

    public void OpenSocialPage()
    {
        SocialWindow.SetActive(true);
    }

    public void OpenWikiPage()
    {
        WikiWindow.SetActive(true);
    }

    public void OpenSecretPage()
    {
        SecretWindow.SetActive(true);
    }

    public void OpenConspiracyPage()
    {
        ConspiracyWindow.SetActive(true);
    }
    public void OpenSearchPage()
    {
        SearchWindow.SetActive(true);
    }

    public void OpenVividDesignPage()
    {
        VividDesignWindow.SetActive(true);
    }

    public void OpenSallyPage()
    {
        SallyWindow.SetActive(true);
    }

    //results

    public void OpenNewsResult()
    {
        NewsResult.SetActive(true);
    }

    public void OpenSocialResult()
    {
        SocialResult.SetActive(true);
    }

    public void OpenWikiResult()
    {
        WikiResult.SetActive(true);
    }

    public void OpenSecretResult()
    {
        SecretResult.SetActive(true);
    }

    public void OpenConspiracyResult()
    {
        ConspiracyResult.SetActive(true);
    }

    public void OpenViviLineResult()
    {
        VividLineResult.SetActive(true);
    }

    public void OpenCoordResult()
    {
        CoordResult.SetActive(true);
    }
}
