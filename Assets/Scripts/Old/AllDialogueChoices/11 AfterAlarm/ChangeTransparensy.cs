using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class ChangeTransparensy : MonoBehaviour
{
    [Header("ImageColor")]
    public Image Color1;
    public TextMeshProUGUI Color2;
    public TextMeshProUGUI Color3;
    [Header("transparency")]
    public float transparency;
    public float transparency2;
    public float transparency3;
    private bool mousehold;
    private bool transition;

    public float n;
    public float n1;
    public float n2;
    public float min;
    public float min2;

    [Header("transition")]
    public GameObject transitiontobed;
    public GameObject bedcamera;
    public GameObject circle;

    //private GameObject SevenMusicTransition;

    void Start()
    {
        bedcamera = GameObject.Find("bedcamera");
    }

    
    void Update()
    {
        if (!transition)
        {
            if (Input.GetMouseButton(0))
            {
                mousehold = true;

            }

            if (!Input.GetMouseButton(0))
            {
                mousehold = false;
            }

            if (mousehold)
            {
                transparency = Mathf.Clamp(transparency += n, min, 1);
                transparency2 = Mathf.Clamp(transparency2 -= n1, min2, 1);
                transparency3 = Mathf.Clamp(transparency3 += n2, min2, 1);
                //Debug.Log(transparency);
                Color1.GetComponent<Image>().color = new Color(Color1.color.r, Color1.color.g, Color1.color.b, transparency);
                Color2.color = new Color(Color2.color.r, Color2.color.g, Color2.color.b, transparency3);
                Color3.color = new Color(Color3.color.r, Color3.color.g, Color3.color.b, transparency2);
            }

            if (!mousehold)
            {
                transparency = Mathf.Clamp(transparency -= n, min, 1);
                transparency2 = Mathf.Clamp(transparency2 += n1, min2, 1);
                transparency3 = Mathf.Clamp(transparency3 -= n2, min2, 1);
                //Debug.Log(transparency);
                Color1.GetComponent<Image>().color = new Color(Color1.color.r, Color1.color.g, Color1.color.b, transparency);
                Color2.color = new Color(Color2.color.r, Color2.color.g, Color2.color.b, transparency3);
                Color3.color = new Color(Color3.color.r, Color3.color.g, Color3.color.b, transparency2);
            }
        }
        

        if (transparency == 1 && !transition)
        {
            transitiontobed.SetActive(true);
            transitiontobed.GetComponent<Animator>().Play("Play");
            bedcamera.GetComponent<CinemachineVirtualCamera>().m_Priority = 40;
            circle.SetActive(false);
            transition = true;
            //SevenMusicTransition = GameObject.Find("SevenMusicTransition");
            //SevenMusicTransition.GetComponent<MusicChange>().ChangeClip();
        }
    }
}
