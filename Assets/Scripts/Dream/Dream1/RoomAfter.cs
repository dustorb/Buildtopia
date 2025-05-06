using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAfter : MonoBehaviour
{
    public GameObject switchTowindows;
    public GameObject switchToboard;
    public GameObject switchTophone;
    public GameObject ringingphone;

    public GameObject Left;
    //public GameObject TurnOnComputer;
    // Start is called before the first frame update
    void Start()
    {
        Left.GetComponent<Animator>().Play("Fade");
        switchToboard.SetActive(true);
        switchTowindows.SetActive(true);
        switchTophone.SetActive(true);
        ringingphone.SetActive(false);
        //TurnOnComputer.SetActive(true);
    }
}
