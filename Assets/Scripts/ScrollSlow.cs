using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollSlow : MonoBehaviour
{
    public ScrollRect myScrollRect;
    public Scrollbar newScrollBar;

    // Update is called once per frame
    void Update()
    {
        if (myScrollRect.verticalNormalizedPosition >= 0f)
        {
            myScrollRect.verticalNormalizedPosition -= 0.0001f;
        }
    }
}
