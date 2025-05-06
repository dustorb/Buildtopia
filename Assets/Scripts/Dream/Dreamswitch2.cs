using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Dreamswitch2 : MonoBehaviour
{
    public Camera cam;
    public CinemachineBrain brain;
    public CinemachineVirtualCamera vc;
    public CinemachineVirtualCamera nextvc;
    public nextVCam NextVcInCamera;
    //public CinemachineVirtualCamera finalCam;

    [Header("allofus")]
    public GameObject circleL;
    public GameObject circleR;
    public GameObject circleB;


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

                if (hit.collider != null && hit.collider.gameObject.name == "R1")
                {
                    circleL.GetComponent<Animator>().Play("Appear");
                    circleR.GetComponent<Animator>().Play("Fade");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "B1")
                {
                    circleL.GetComponent<Animator>().Play("Appear");
                    circleR.GetComponent<Animator>().Play("Appear");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "R2")
                {
                    circleL.GetComponent<Animator>().Play("Fade");
                    circleR.GetComponent<Animator>().Play("Fade");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "B2")
                {
                    circleL.GetComponent<Animator>().Play("Fade");
                    circleR.GetComponent<Animator>().Play("Fade");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "L2")
                {
                    circleL.GetComponent<Animator>().Play("Stay");
                    circleR.GetComponent<Animator>().Play("Fade");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "B3")
                {
                    circleL.GetComponent<Animator>().Play("Appear");
                    circleR.GetComponent<Animator>().Play("Appear");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "Panel")
                {
                    circleL.GetComponent<Animator>().Play("Appear");
                    circleR.GetComponent<Animator>().Play("Stay");
                    circleB.GetComponent<Animator>().Play("Fade");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "L4")
                {
                    circleL.GetComponent<Animator>().Play("Fade");
                    circleR.GetComponent<Animator>().Play("Stay");
                    circleB.GetComponent<Animator>().Play("Appear");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "L5")
                {
                    circleL.GetComponent<Animator>().Play("Fade");
                    circleR.GetComponent<Animator>().Play("Stay");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "B5")
                {
                    circleL.GetComponent<Animator>().Play("Stay");
                    circleR.GetComponent<Animator>().Play("Appear");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "B6")
                {
                    circleL.GetComponent<Animator>().Play("Stay");
                    circleR.GetComponent<Animator>().Play("Stay");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
                else if (hit.collider != null && hit.collider.gameObject.name == "L7")
                {
                    circleL.GetComponent<Animator>().Play("Fade");
                    circleR.GetComponent<Animator>().Play("Appear");
                    circleB.GetComponent<Animator>().Play("Stay");
                }
            }

            
            
        }

        
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
