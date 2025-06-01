using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchButton : MonoBehaviour
{
    [Header("tmp")]
    public TMP_InputField input;
    public string nameOfInput;
    //public GameObject lastwindow;
    [Header("windows")]
    public GameObject SocialWindow;
    public GameObject WikiWindow;
    public GameObject SecretWindow;
    public GameObject NewsWindow;
    public GameObject ConspiracyWindow;
    public GameObject CoordWindow;
    public GameObject VividWindow;
    [Header("tabs")]
    public GameObject scrollViewContent;
    public GameObject SocialTab;
    public GameObject WikiTab;
    public GameObject SecretTab;
    public GameObject NewsTab;
    public GameObject ConspiracyTab;
    public GameObject VividTab;
    public GameObject CoordTab;
    public ChangeHierarchy ChangeHierarchy;

    void Start()
    {
        input = GameObject.Find(nameOfInput).GetComponent<TMP_InputField>();
    }

    public void Search()
    {
        if (input.text == "BuildTopia ���" 
            || input.text == "buildtopia ���"
            || input.text == "buildtopia ����"
            ||  input.text == "�������� �� ����" 
            ||  input.text == "BuildTopia �������� �� ����" 
            ||  input.text == "buildtopia �������� �� ����" 
            || input.text == "BuildTopia ��� ����"
            || input.text == "BuildTopia"
            || input.text == "BuildTopia ����"
            || input.text == "���� ���"
            || input.text == "��������� ����"
            || input.text == "��������� ����"
            || input.text == "���������"
            || input.text == "��������� ���")
        {
            NewsWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(NewsTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsNews").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
        }
        //else if ( input.text == "���������" ||  input.text == "���������" ||  input.text == "�������" ||  input.text == "�������")
        //{
        //    SocialWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(SocialTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsSocial").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //}
        //else if (input.text == "VividLine" || input.text == "vividline" || input.text == "Vivid line" || input.text == "vivid line")
        //{
        //    VividWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(VividTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsVividLine").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //}
        //else if (input.text == "MQS" || input.text == "Mqs" || input.text == "mqs")
        //{
        //    SecretWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(SecretTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsSecret").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //}
        //else if (input.text == "��������������" || input.text == "��������������" ||  input.text == "������������������" ||  input.text == "������������������" || input.text == "�������������� �����" ||  input.text == "�������������� �����" || input.text == "�������������� �����" || input.text == "�������������� �����")
        //{
        //    ConspiracyWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(ConspiracyTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsConspiracy").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //}
        //else if (input.text == "26.624974, -80.227744")
        //{
        //    CoordWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(CoordTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsCoordLine").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //    //input.text = "";
        //}

    }
}
