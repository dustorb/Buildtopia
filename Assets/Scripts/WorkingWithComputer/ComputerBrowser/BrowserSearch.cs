using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrowserSearch : MonoBehaviour
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && input.text == "Новости" || Input.GetKeyDown(KeyCode.Return) && input.text == "новости" || Input.GetKeyDown(KeyCode.Return) && input.text == "Салли Джонс" || Input.GetKeyDown(KeyCode.Return) && input.text == "салли джонс" || Input.GetKeyDown(KeyCode.Return) && input.text == "Салли джонс" || Input.GetKeyDown(KeyCode.Return) && input.text == "салли Джонс")
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

        if (Input.GetKeyDown(KeyCode.Return) && input.text == "Сообщения" || Input.GetKeyDown(KeyCode.Return) && input.text == "сообщения" || Input.GetKeyDown(KeyCode.Return) && input.text == "Фейскук" || Input.GetKeyDown(KeyCode.Return) && input.text == "фейскук")
        {
            SocialWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(SocialTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsSocial").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
            //input.text = "";
        }
        //else if (Input.GetKeyDown(KeyCode.Return) && input.text == "VividLine" || Input.GetKeyDown(KeyCode.Return) && input.text == "vividline" || Input.GetKeyDown(KeyCode.Return) && input.text == "Vivid Line" || Input.GetKeyDown(KeyCode.Return) && input.text == "vivid line")
        //{
        //    WikiWindow.SetActive(true);
        //    GameObject tab = (GameObject)Instantiate(WikiTab);
        //    tab.transform.SetParent(scrollViewContent.transform);
        //    tab.transform.localScale = Vector2.one;
        //    tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        //    tab.transform.rotation = scrollViewContent.transform.rotation;
        //    ChangeHierarchy = GameObject.Find("ResultsWiki").GetComponent<ChangeHierarchy>();
        //    ChangeHierarchy.HigherInHierarchy();
        //}
        else if (Input.GetKeyDown(KeyCode.Return) && input.text == "MQS" || Input.GetKeyDown(KeyCode.Return) && input.text == "Mqs" || Input.GetKeyDown(KeyCode.Return) && input.text == "mqs")
        {
            SecretWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(SecretTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsSecret").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
            //input.text = "";
        }
        else if (Input.GetKeyDown(KeyCode.Return) && input.text == "Паранормальный" || Input.GetKeyDown(KeyCode.Return) && input.text == "паранормальный" || Input.GetKeyDown(KeyCode.Return) && input.text == "конспирологический" || Input.GetKeyDown(KeyCode.Return) && input.text == "конспирологический" || Input.GetKeyDown(KeyCode.Return) && input.text == "Паранормальный форум" || Input.GetKeyDown(KeyCode.Return) && input.text == "Паранормальный Форум" || Input.GetKeyDown(KeyCode.Return) && input.text == "паранормальный форум" || Input.GetKeyDown(KeyCode.Return) && input.text == "паранормальный Форум")
        {
            ConspiracyWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(ConspiracyTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsConspiracy").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
            //input.text = "";
        }
        else if (Input.GetKeyDown(KeyCode.Return) && input.text == "26.624974, -80.227744" || Input.GetKeyDown(KeyCode.Return) && input.text == "26.624974 -80.227744" || Input.GetKeyDown(KeyCode.Return) && input.text == "26.624974-80.227744")
        {
            CoordWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(CoordTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsCoordLine").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
            //input.text = "";
        }
        else if (Input.GetKeyDown(KeyCode.Return) && input.text == "VividLine" || Input.GetKeyDown(KeyCode.Return) && input.text == "vividline" || Input.GetKeyDown(KeyCode.Return) && input.text == "Vivid Line" || Input.GetKeyDown(KeyCode.Return) && input.text == "vivid line")
        {
            VividWindow.SetActive(true);
            GameObject tab = (GameObject)Instantiate(VividTab);
            tab.transform.SetParent(scrollViewContent.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = scrollViewContent.transform.rotation;
            ChangeHierarchy = GameObject.Find("ResultsVividLine").GetComponent<ChangeHierarchy>();
            ChangeHierarchy.HigherInHierarchy();
            //input.text = "";
        }



    }

}
