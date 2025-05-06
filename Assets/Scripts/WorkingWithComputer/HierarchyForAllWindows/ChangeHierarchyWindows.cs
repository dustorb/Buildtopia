using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHierarchyWindows : MonoBehaviour
{
    public int m_IndexNumber;
    public bool amIBrowser;
    public bool amIGame;


    void Start()
    {
        if (amIBrowser)
        {
            m_IndexNumber = 1;
        }
        transform.SetSiblingIndex(m_IndexNumber);

    }

    private void Update()
    {
        if (amIGame)
        {
            if(m_IndexNumber > 8)
            {
                ((RectTransform)transform).anchoredPosition = new Vector3(GetComponent<RectTransform>().anchoredPosition.x,
                                                                           GetComponent<RectTransform>().anchoredPosition.y,
                                                                           1);
            }
        }
    }
    void OnEnable()
    {
        //Initialise the Sibling Index to 0
        m_IndexNumber = 8;
        //Set the Sibling Index
        transform.SetSiblingIndex(m_IndexNumber);

    }

    public void HigherInHierarchy()
    {
        transform.SetSiblingIndex(m_IndexNumber);
        if (m_IndexNumber <= transform.GetSiblingIndex())
        {
            //Increase the Index Number
            //m_IndexNumber++;
            m_IndexNumber = 7;
            //Update the Sibling Index of the GameObject
            transform.SetSiblingIndex(m_IndexNumber);

            if (amIGame)
            {
                //transform.position = new Vector3(transform.position.x, transform.position.y, -5);

                ((RectTransform)transform).anchoredPosition = new Vector3(GetComponent<RectTransform>().anchoredPosition.x,
                                                                             GetComponent<RectTransform>().anchoredPosition.y,
                                                                             -5);
            }
        }
    }

    public void LowerInHierarchy()
    {
        transform.SetSiblingIndex(m_IndexNumber);
        //Make sure the index number doesn't go below 0
        if (m_IndexNumber >= 1)
        {
            //Decrease the index number
            m_IndexNumber--;
            //Update the Sibling Index of the GameObject
            transform.SetSiblingIndex(m_IndexNumber);

            if (amIGame)
            {

                ((RectTransform)transform).anchoredPosition = new Vector3(GetComponent<RectTransform>().anchoredPosition.x,
                                                                             GetComponent<RectTransform>().anchoredPosition.y,
                                                                             1);
            }
        }
    }
}
