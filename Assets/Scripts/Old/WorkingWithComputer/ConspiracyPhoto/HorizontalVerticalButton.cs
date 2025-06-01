using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalVerticalButton : MonoBehaviour
{
    [Header("HorizontalVerticalPhotoChange")]
    public HorizontalVerticalPhotoChange photo1HV;
    public HorizontalVerticalPhotoChange photo2HV;
    public HorizontalVerticalPhotoChange photo3HV;
    public HorizontalVerticalPhotoChange photo4HV;
    public HorizontalVerticalPhotoChange photo5HV;
    public HorizontalVerticalPhotoChange photo6HV;
    public HorizontalVerticalPhotoChange photo7HV;
    [Header("Photo")]
    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;
    public GameObject photo5;
    public GameObject photo6;
    public GameObject photo7;

    public void makeHorizontal()
    {
        if (photo1.activeSelf)
        {
            photo1HV.Horizontal();
        }
        else if (photo2.activeSelf)
        {
            photo2HV.Horizontal();
        }
        else if (photo3.activeSelf)
        {
            photo3HV.Horizontal();
        }
        else if (photo4.activeSelf)
        {
            photo4HV.Horizontal();
        }
        else if (photo5.activeSelf)
        {
            photo5HV.Horizontal();
        }
        else if (photo6.activeSelf)
        {
            photo6HV.Horizontal();
        }
        else if (photo7.activeSelf)
        {
            photo7HV.Horizontal();
        }
    }

    public void makeVertical()
    {
        if (photo1.activeSelf)
        {
            photo1HV.Vertical();
        }
        else if (photo2.activeSelf)
        {
            photo2HV.Vertical();
        }
        else if (photo3.activeSelf)
        {
            photo3HV.Vertical();
        }
        else if (photo4.activeSelf)
        {
            photo4HV.Vertical();
        }
        else if (photo5.activeSelf)
        {
            photo5HV.Vertical();
        }
        else if (photo6.activeSelf)
        {
            photo6HV.Vertical();
        }
        else if (photo7.activeSelf)
        {
            photo7HV.Vertical();
        }
    }
}
