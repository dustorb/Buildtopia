using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadImages : MonoBehaviour
{
    [Header("ContentScrollView")]
    public GameObject ContentConpiracy;
    public GameObject ContentFolder;
    public GameObject ContentDecoder;

    [Header("Photo1")]
    public GameObject PhotoForConspiracy1;
    public GameObject PhotoForFolder1;
    public GameObject PhotoForDecoder1;
    public GameObject DownloadPhotoButton1;
    public bool CanDownload1;
    public bool alreadyDownload1;

    //[Header("Photo2")]
    //public GameObject PhotoForConspiracy2;
    //public GameObject PhotoForFolder2;
    //public GameObject PhotoForDecoder2;
    //public GameObject DownloadPhotoButton2;
    //public bool CanDownload2;
    //public bool alreadyDownload2;

    //[Header("Photo3")]
    //public GameObject PhotoForConspiracy3;
    //public GameObject PhotoForFolder3;
    //public GameObject PhotoForDecoder3;
    //public GameObject DownloadPhotoButton3;
    //public bool CanDownload3;
    //public bool alreadyDownload3;

    //[Header("Photo4")]
    //public GameObject PhotoForConspiracy4;
    //public GameObject PhotoForFolder4;
    //public GameObject PhotoForDecoder4;
    //public GameObject DownloadPhotoButton4;
    //public bool CanDownload4;
    //public bool alreadyDownload4;

    //[Header("Photo5")]
    //public GameObject PhotoForConspiracy5;
    //public GameObject PhotoForFolder5;
    //public GameObject PhotoForDecoder5;
    //public GameObject DownloadPhotoButton5;
    //public bool CanDownload5;
    //public bool alreadyDownload5;

    //[Header("Photo6")]
    //public GameObject PhotoForConspiracy6;
    //public GameObject PhotoForFolder6;
    //public GameObject PhotoForDecoder6;
    //public GameObject DownloadPhotoButton6;
    //public bool CanDownload6;
    //public bool alreadyDownload6;

    //[Header("Photo7")]
    //public GameObject PhotoForConspiracy7;
    //public GameObject PhotoForFolder7;
    //public GameObject PhotoForDecoder7;
    //public GameObject DownloadPhotoButton7;
    //public bool CanDownload7;
    //public bool alreadyDownload7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CanDownloadImage1()
    {
        if (!alreadyDownload1)
        {
            if (!CanDownload1)
            {
                CanDownload1 = true;
                DownloadPhotoButton1.SetActive(false);
            }
            if (CanDownload1)
            {
                CanDownload1 = false;
                DownloadPhotoButton1.SetActive(true);
            }
        }
    }

    //public void CanDownloadImage2()
    //{
    //    if (!alreadyDownload2)
    //    {
    //        if (!CanDownload2)
    //        {
    //            CanDownload2 = true;
    //            DownloadPhotoButton2.SetActive(false);
    //        }
    //        if (CanDownload2)
    //        {
    //            CanDownload2 = false;
    //            DownloadPhotoButton2.SetActive(true);
    //        }
    //    }
    //}

    //public void CanDownloadImage3()
    //{
    //    if (!alreadyDownload3)
    //    {
    //        if (!CanDownload3)
    //        {
    //            CanDownload3 = true;
    //            DownloadPhotoButton3.SetActive(false);
    //        }
    //        if (CanDownload3)
    //        {
    //            CanDownload3 = false;
    //            DownloadPhotoButton3.SetActive(true);
    //        }
    //    }
    //}

    //public void CanDownloadImage4()
    //{
    //    if (!alreadyDownload4)
    //    {
    //        if (!CanDownload4)
    //        {
    //            CanDownload4 = true;
    //            DownloadPhotoButton4.SetActive(false);
    //        }
    //        if (CanDownload4)
    //        {
    //            CanDownload4 = false;
    //            DownloadPhotoButton4.SetActive(true);
    //        }
    //    }
    //}


    //public void CanDownloadImage5()
    //{
    //    if (!alreadyDownload5)
    //    {
    //        if (!CanDownload5)
    //        {
    //            CanDownload5 = true;
    //            DownloadPhotoButton5.SetActive(false);
    //        }
    //        if (CanDownload5)
    //        {
    //            CanDownload5 = false;
    //            DownloadPhotoButton5.SetActive(true);
    //        }
    //    }
    //}

    //public void CanDownloadImage6()
    //{
    //    if (!alreadyDownload6)
    //    {
    //        if (!CanDownload6)
    //        {
    //            CanDownload6 = true;
    //            DownloadPhotoButton6.SetActive(false);
    //        }
    //        if (CanDownload6)
    //        {
    //            CanDownload6 = false;
    //            DownloadPhotoButton6.SetActive(true);
    //        }
    //    }
    //}

    //public void CanDownloadImage7()
    //{
    //    if (!alreadyDownload7)
    //    {
    //        if (!CanDownload7)
    //        {
    //            CanDownload7 = true;
    //            DownloadPhotoButton7.SetActive(false);
    //        }
    //        if (CanDownload7)
    //        {
    //            CanDownload7 = false;
    //            DownloadPhotoButton7.SetActive(true);
    //        }
    //    }
    //}


    public void DownloadImage1()
    {
        GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy1);
        imageCP.transform.SetParent(ContentConpiracy.transform);
        imageCP.transform.localScale = Vector2.one;
        imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        imageCP.transform.rotation = ContentConpiracy.transform.rotation;

        GameObject imageF = (GameObject)Instantiate(PhotoForFolder1);
        imageF.transform.SetParent(ContentFolder.transform);
        imageF.transform.localScale = Vector2.one;
        imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        imageF.transform.rotation = ContentFolder.transform.rotation;

        GameObject imageD = (GameObject)Instantiate(PhotoForDecoder1);
        imageD.transform.SetParent(ContentDecoder.transform);
        imageD.transform.localScale = Vector2.one;
        imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        imageD.transform.rotation = ContentDecoder.transform.rotation;

        alreadyDownload1 = true;
        DownloadPhotoButton1.SetActive(false);
    }

    //public void DownloadImage2()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy2);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder2);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder2);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload2 = true;
    //    DownloadPhotoButton2.SetActive(false);
    //}

    //public void DownloadImage3()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy3);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder3);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder3);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload3 = true;
    //    DownloadPhotoButton3.SetActive(false);
    //}

    //public void DownloadImage4()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy4);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder4);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder4);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload4 = true;
    //    DownloadPhotoButton4.SetActive(false);
    //}

    //public void DownloadImage5()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy5);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder5);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder5);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload5 = true;
    //    DownloadPhotoButton5.SetActive(false);
    //}

    //public void DownloadImage6()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy6);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder6);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder6);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload6 = true;
    //    DownloadPhotoButton6.SetActive(false);
    //}

    //public void DownloadImage7()
    //{
    //    GameObject imageCP = (GameObject)Instantiate(PhotoForConspiracy7);
    //    imageCP.transform.SetParent(ContentConpiracy.transform);
    //    imageCP.transform.localScale = Vector2.one;
    //    imageCP.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageCP.transform.rotation = ContentConpiracy.transform.rotation;

    //    GameObject imageF = (GameObject)Instantiate(PhotoForFolder7);
    //    imageF.transform.SetParent(ContentFolder.transform);
    //    imageF.transform.localScale = Vector2.one;
    //    imageF.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageF.transform.rotation = ContentFolder.transform.rotation;

    //    GameObject imageD = (GameObject)Instantiate(PhotoForDecoder7);
    //    imageD.transform.SetParent(ContentDecoder.transform);
    //    imageD.transform.localScale = Vector2.one;
    //    imageD.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    //    imageD.transform.rotation = ContentDecoder.transform.rotation;

    //    alreadyDownload7 = true;
    //    DownloadPhotoButton7.SetActive(false);
    //}
}
