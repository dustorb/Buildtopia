using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableOpenSallyPage : MonoBehaviour
{
    public GameObject SocialPage;
    public GameObject SallyPage;

    void OnEnable()
    {
        SocialPage.SetActive(true);
        SallyPage.SetActive(true);
    }
}
