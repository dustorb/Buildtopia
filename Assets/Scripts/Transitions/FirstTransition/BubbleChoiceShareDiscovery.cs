using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleChoiceShareDiscovery : MonoBehaviour
{
    public FindKeyWord FindKeyWord;

    // Start is called before the first frame update
    public void Share()
    {
        FindKeyWord = GameObject.Find("FindKeyWord").GetComponent<FindKeyWord>();
        FindKeyWord.ShareYourDiscovery();
    }
}
