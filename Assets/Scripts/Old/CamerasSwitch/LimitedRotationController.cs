using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class LimitedRotationController : MonoBehaviour
{
    public LimitedRotation LimitedRotation;
    public CinemachineVirtualCamera ThisCinemachine;
    public float time = 2f;


    // Update is called once per frame
    void Update()
    {
        if (ThisCinemachine.Priority == 20)
        {
            StartCoroutine(WaitBeforeSwitchToOtherCamera());
        }
        else
        {
            LimitedRotation.enabled = false;
        }
    }

    IEnumerator WaitBeforeSwitchToOtherCamera()
    {
        yield return new WaitForSeconds(time);
        LimitedRotation.enabled = true;
    }
}

