using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoManager : MonoBehaviour
{

    [Header("PhotoReference")]

    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;
    public GameObject photo5;
    public GameObject photo6;
    public GameObject photo7;

    public void OpenPhoto1()
    {
        photo1.SetActive(true);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(false);
    }

    public void OpenPhoto2()
    {
        photo1.SetActive(false);
        photo2.SetActive(true);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(false);
    }

    public void OpenPhoto3()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(true);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(false);
    }

    public void OpenPhoto4()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(true);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(false);
    }

    public void OpenPhoto5()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(true);
        photo6.SetActive(false);
        photo7.SetActive(false);
    }

    public void OpenPhoto6()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(true);
        photo7.SetActive(false);
    }

    public void OpenPhoto7()
    {
        photo1.SetActive(false);
        photo2.SetActive(false);
        photo3.SetActive(false);
        photo4.SetActive(false);
        photo5.SetActive(false);
        photo6.SetActive(false);
        photo7.SetActive(true);
    }

}
