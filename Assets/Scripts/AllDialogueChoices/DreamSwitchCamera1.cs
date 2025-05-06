using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DreamSwitchCamera1 : MonoBehaviour
{
    public Camera cam;
    public CinemachineBrain brain;
    public CinemachineVirtualCamera vc;
    public CinemachineVirtualCamera nextvc;
    public nextVCam NextVcInCamera;
    //public CinemachineVirtualCamera finalCam;
    //public WTransition WTransition;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.tag == "GoForward")
                {
                    GoForward();
                }
                else if (hit.collider != null && hit.collider.tag == "GoBack")
                {
                    GoBack();
                }
                else if (hit.collider != null && hit.collider.tag == "GoLeft")
                {
                    GoLeft();
                }
                else if (hit.collider != null && hit.collider.tag == "GoRight")
                {
                    GoRight();
                }
                else if (hit.collider != null && hit.collider.tag == "GoMiddle")
                {
                    GoMiddle();
                }
            }
        }

        //if (vc == finalCam)
        //{
        //    WTransition.StartTrans();
        //}
    }
    public void GoBack()
    {
        vc = brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        vc.m_Priority -= 1;
    }

    public void GoForward()
    {
        vc = brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        NextVcInCamera = vc.GetComponent<nextVCam>();
        nextvc = NextVcInCamera.vc;
        nextvc.m_Priority += 1;
    }

    public void GoLeft()
    {
        vc = brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        NextVcInCamera = vc.GetComponent<nextVCam>();
        nextvc = NextVcInCamera.vc;
        nextvc.m_Priority += 1;
    }

    public void GoRight()
    {
        vc = brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        NextVcInCamera = vc.GetComponent<nextVCam>();
        nextvc = NextVcInCamera.vc1;
        nextvc.m_Priority += 1;
    }
    public void GoMiddle()
    {
        vc = brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        NextVcInCamera = vc.GetComponent<nextVCam>();
        nextvc = NextVcInCamera.vc2;
        nextvc.m_Priority += 1;
    }
}
