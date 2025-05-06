using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBright : MonoBehaviour
{
    public Slider slider;

    [Header("ImageColor")]
    public Image Color1;
    //public Image Color2;
    //public Image Color3;
    //public Image Color4;
    //public Image Color5;
    //public Image Color6;
    //public Image Color7;

    //[Header("Photo")]
    //public GameObject photo1;
    //public GameObject photo2;
    //public GameObject photo3;
    //public GameObject photo4;
    //public GameObject photo5;
    //public GameObject photo6;
    //public GameObject photo7;


    public void Bright()
    {
        Color1.GetComponent<Image>().color = new Color(Color1.color.r, Color1.color.g, Color1.color.b, slider.value);
        //if (photo1.activeSelf)
        //{
        //    Color1.GetComponent<Image>().color = new Color(Color1.color.r, Color1.color.g, Color1.color.b, slider.value);
        //}
        //else if (photo2.activeSelf)
        //{
        //    Color2.GetComponent<Image>().color = new Color(Color2.color.r, Color2.color.g, Color2.color.b, slider.value);
        //}
        //else if (photo3.activeSelf)
        //{
        //    Color3.GetComponent<Image>().color = new Color(Color3.color.r, Color3.color.g, Color3.color.b, slider.value);
        //}
        //else if (photo4.activeSelf)
        //{
        //    Color4.GetComponent<Image>().color = new Color(Color4.color.r, Color4.color.g, Color4.color.b, slider.value);
        //}
        //else if (photo5.activeSelf)
        //{
        //    Color5.GetComponent<Image>().color = new Color(Color5.color.r, Color5.color.g, Color5.color.b, slider.value);
        //}
        //else if (photo6.activeSelf)
        //{
        //    Color6.GetComponent<Image>().color = new Color(Color6.color.r, Color6.color.g, Color6.color.b, slider.value);
        //}
        //else if (photo7.activeSelf)
        //{
        //    Color7.GetComponent<Image>().color = new Color(Color7.color.r, Color7.color.g, Color7.color.b, slider.value);
        //}

    }
}
