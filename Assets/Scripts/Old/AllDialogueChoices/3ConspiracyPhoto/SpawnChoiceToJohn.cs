using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChoiceToJohn : MonoBehaviour
{
    
    public GameObject ContentMessangerSocial;
    public GameObject BubbleChoice;
    //public string nameOfContent;

    void Start()
    {
        //ContentMessangerSocial = GameObject.Find("ContentMessangerSocial");
    }

    public void Choice()
    {
        GameObject message = (GameObject)Instantiate(BubbleChoice);
        message.transform.SetParent(ContentMessangerSocial.transform);
        message.transform.localScale = new Vector3(1, 1, 1);
        message.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        message.transform.rotation = ContentMessangerSocial.transform.rotation;
    }
}
