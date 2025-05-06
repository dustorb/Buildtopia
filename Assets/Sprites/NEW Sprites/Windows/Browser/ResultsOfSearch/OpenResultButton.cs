using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenResultButton : MonoBehaviour
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
    [Header("tabs")]
    public GameObject scrollViewContent;
    public GameObject SocialTab;
    public GameObject WikiTab;
    public GameObject SecretTab;
    public GameObject NewsTab;
    public GameObject ConspiracyTab;
    public GameObject SearchTab;
    public GameObject VividDesignTab;
    public GameObject SallyTab;
    public ChangeHierarchy ChangeHierarchy;



    public void OpenSocial()
    {
        SocialWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(SocialTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("SocialBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenWiki()
    {
        WikiWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(WikiTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("WikiBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenSecret()
    {
        SecretWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(SecretTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("SecretBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenNews()
    {
        NewsWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(NewsTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("NewsBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenConspiracy()
    {
        ConspiracyWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(ConspiracyTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("ConspiracyBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenSearch()
    {
        SearchWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(SearchTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("BrowserSearchPageCopy").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenSally()
    {
        SallyWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(SallyTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("SocialBrowserPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }

    public void OpenVividDesign()
    {
        VividDesignWindow.SetActive(true);
        GameObject tab = (GameObject)Instantiate(VividDesignTab);
        tab.transform.SetParent(scrollViewContent.transform);
        tab.transform.localScale = Vector2.one;
        tab.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        tab.transform.rotation = scrollViewContent.transform.rotation;
        ChangeHierarchy = GameObject.Find("VividDesignPage").GetComponent<ChangeHierarchy>();
        ChangeHierarchy.HigherInHierarchy();
    }
}
