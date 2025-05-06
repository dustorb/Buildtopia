using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WindowsController : MonoBehaviour
{
    public GameObject window;
    public CinemachineVirtualCamera ThisCinemachine;


    void Update()
    {
        if (ThisCinemachine.Priority == 20)
        {
            window.SetActive(true);
        }
        else
        {
            window.SetActive(false);
        }
    }


}
