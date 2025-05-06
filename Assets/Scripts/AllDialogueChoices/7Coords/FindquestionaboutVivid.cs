using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindquestionaboutVivid : MonoBehaviour
{
    public GameObject vivid;

    public void Delete()
    {
        vivid = GameObject.Find("AnyInfoBubble(Clone)");
        if (vivid != null)
        {
            Destroy(GameObject.Find("AnyInfoBubble(Clone)"));
        }
    }
}
