using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoCheck : MonoBehaviour
{
    public GameObject photo2;
    public GameObject SymbolOnPhoto;
    public Transform pscale;
    public Image pbright;
    public float x;
    public float y;
    public float z;
    public float r;
    public float g;
    public float b;
    public float a;

    public float xPHOTO;
    public float yPHOTO;
    public float zPHOTO;

    public bool symbol;

    void Start()
    {
        //pscale = photo2.GetComponent<RectTransform>();
        //pbright = photo2.GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!symbol)
        {
            xPHOTO = pscale.localScale.x;
            yPHOTO = pscale.localScale.y;
            zPHOTO = pscale.localScale.z;

            //if (pscale.localScale.x == x && pscale.localScale.y == y && pscale.localScale.z == z && pbright.color.r == r && pbright.color.g == g && pbright.color.b == b && pbright.color.a == a /*&& SymbolOnPhoto.active == false*/)
            //{
            //    SymbolOnPhoto.SetActive(true);
            //}

            if (xPHOTO == x && yPHOTO == y && zPHOTO == z)
            {
                SymbolOnPhoto.SetActive(true);
                symbol = true;
            }

             
        }
        


    }
}
