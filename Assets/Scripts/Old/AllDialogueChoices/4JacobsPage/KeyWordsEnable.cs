using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWordsEnable : MonoBehaviour
{
    public GameObject KeywordFriends;
    public GameObject KeywordReposts;
    public GameObject KeywordDonation;
    public GameObject KeywordPhoneNumber;

    void OnEnable()
    {
        KeywordFriends.SetActive(true);
        KeywordReposts.SetActive(true);
        KeywordDonation.SetActive(true);
        KeywordPhoneNumber.SetActive(true);
    }
}
