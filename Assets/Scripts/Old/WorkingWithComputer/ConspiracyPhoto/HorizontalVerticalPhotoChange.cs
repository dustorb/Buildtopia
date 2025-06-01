using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalVerticalPhotoChange : MonoBehaviour
{
    public RectTransform photo1;
    public RectTransform photo2;

    public float photoX;
    public float photoY;

    bool changedH;
    bool changedV;

    public void Horizontal()
    {
        if (changedH)
        {
            changedH = !changedH;
            photo1.GetComponent<RectTransform>().localScale = new Vector3(-photoX, photo1.localScale.y, photo1.localScale.z);
            photo2.GetComponent<RectTransform>().localScale = new Vector3(-photoX, photo2.localScale.y, photo2.localScale.z);
        }
        else
        {
            changedH = !changedH;
            photo1.GetComponent<RectTransform>().localScale = new Vector3(photoX, photo1.localScale.y, photo1.localScale.z);
            photo2.GetComponent<RectTransform>().localScale = new Vector3(photoX, photo2.localScale.y, photo2.localScale.z);
        }
    }

    public void Vertical()
    {
        if (changedV)
        {
            changedV = !changedV;
            photo1.GetComponent<RectTransform>().localScale = new Vector3(photo1.localScale.x, -photoY, photo1.localScale.z);
            photo2.GetComponent<RectTransform>().localScale = new Vector3(photo2.localScale.x, -photoY, photo2.localScale.z);
        }
        else
        {
            changedV = !changedV;
            photo1.GetComponent<RectTransform>().localScale = new Vector3(photo1.localScale.x, photoY, photo1.localScale.z);
            photo2.GetComponent<RectTransform>().localScale = new Vector3(photo2.localScale.x, photoY, photo2.localScale.z);
        }
    }
}
