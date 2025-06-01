using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOutEvent : MonoBehaviour
{
    public float time = 2f;
    public bool BlackOutStart;

    public GameObject lightsInScene;
    public GameObject lightsBoard;
    public GameObject lightsComputerBlock;
    public GameObject Windows;
    public Light computerTurnOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BlackOutStart = true;
        }
        if (BlackOutStart)
        {
            lightsInScene.SetActive(false);
            computerTurnOff.color = Color.red;
            lightsComputerBlock.SetActive(false);
            lightsBoard.SetActive(false);
            if (Windows.activeSelf)
            {
                Windows.SetActive(false);
            }
            StartCoroutine(BlackOut());

        }
    }

    IEnumerator BlackOut()
    {
        BlackOutStart = false;
        yield return new WaitForSeconds(time);
        lightsInScene.SetActive(true);
        lightsComputerBlock.SetActive(true);
        lightsBoard.SetActive(true);
    }
}
