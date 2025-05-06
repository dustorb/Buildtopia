using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWord : MonoBehaviour
{
    public GameObject keyword;

    public void KeywordClicked()
    {
        keyword.SetActive(false);
    }
}
