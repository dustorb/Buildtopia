using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionFromfindreamtofinroom : MonoBehaviour
{
    public GameObject blackBG;

    // Start is called before the first frame update
    public void Trans()
    {
        blackBG.SetActive(true);
        blackBG.GetComponent<Animator>().Play("Play");
    }
}
