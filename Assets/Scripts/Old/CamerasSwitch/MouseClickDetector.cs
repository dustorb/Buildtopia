using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using DialogueEditor;

public class MouseClickDetector : MonoBehaviour
{
    [Header("Cinemachine")]
    public CinemachineVirtualCamera Computer;
    public CinemachineVirtualCamera Board;
    public CinemachineVirtualCamera Windows;
    public CinemachineVirtualCamera Telephone;
    public CinemachineVirtualCamera CompShelf;
    public CinemachineVirtualCamera RoomShelf;

    [Header("CurrentCam")]
   
    public Camera cam;

    [Header("ComputerTurnOn")]
    public Light light;
    private bool red;
    public OpenCloseButton computerWindows;
    public AudioManager AudioManager;


    [Header("PhoneNumbersAnimation")]
    public Animator num1;
    public Animator num2;
    public Animator num3;
    public Animator num4;
    public Animator num5;
    public Animator num6;
    public Animator num7;
    public Animator num8;
    public Animator num9;
    public Animator num0;


    [Header("ActivatePhone")]
    public GameObject canvas;
    public GameObject phoneActivator;
    public GameObject switchToComputer;
    public GameObject EnterNumberCanvas;
    public TMP_Text numberText;
    public GameObject numbersCollider;


    [Header("WindowsSwitch")]
    public GameObject WindowsSwitch1;
    public GameObject WindowsSwitch2;

    [Header("Visual Pointer")]
    public GameObject leftPoint;
    public GameObject rightPoint;
    public Animator leftP;
    public Animator rightP;

    [Header("Audiosource")]
    //public AudioSource Chair;
   
    public AudioSource TelephoneButton;
    public AudioClip PhoneButton;

    [Header("dialogue")]
    [SerializeField] private NPCConversation myConversation1; // монолог "а я включил компьютер?"
    [SerializeField] private NPCConversation myConversation2; // монолог "кажется я собирался сесть в компьютер"
    public bool beforefirstcomputerinteraction;
    public bool timerwork;

    void Start()
    {
        //Chair = GameObject.Find("Chair").GetComponent<AudioSource>();
        
        TelephoneButton = GameObject.Find("TelephoneButton").GetComponent<AudioSource>();

        //leftPoint = GameObject.Find("Left");
        //rightPoint = GameObject.Find("Right");

        //leftP = GameObject.Find("Left").GetComponent<Animator>();
        //rightP = GameObject.Find("Right").GetComponent<Animator>();

        light = GameObject.Find("PointLightForComputerBlock").GetComponent<Light>();

        if (GameObject.Find("WindowsComputerCanvas") != null)
        {
            red = false;
            light.color = Color.green;
        }
        else
        {
            red = true;
        }

        computerWindows = GameObject.Find("ComputerCanvas").GetComponent<OpenCloseButton>();
       
    }

    void Update()
    {
        if (beforefirstcomputerinteraction && !timerwork)
        {
            timerwork = true;
            StartCoroutine(Timer()); 
        }

        if (Input.GetMouseButtonDown(0))
        {


            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;



            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.tag == "ComputerSwitch") //"ComputerSwitch"
                {
                    
                    Computer.m_Priority = 20;
                    Board.m_Priority = 5;
                    Windows.m_Priority = 5;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 5;

                    WindowsSwitch1.SetActive(false);
                    WindowsSwitch2.SetActive(false);

                    if (EnterNumberCanvas.activeSelf)
                    {
                        EnterNumberCanvas.SetActive(false);
                        numbersCollider.SetActive(false);
                        phoneActivator.SetActive(true);
                        numberText.text = "";
                    }

                    //leftP.Play("Appear");
                    //rightP.Play("Stay");
                    



                }
                else if (hit.collider != null && hit.collider.tag == "BoardSwitch")
                {
                    
                    Board.m_Priority = 20;
                    Computer.m_Priority = 5;
                    Windows.m_Priority = 5;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 5;

                    phoneActivator.SetActive(false);
                    //SwitchFromBoardToWindows.SetActive(true);
                    //switchToboard.SetActive(false);

                    //Chair.Play();

                    //leftP.Play("Fade");
                    //rightP.Play("Appear");
                    

                }
                else if (hit.collider != null && hit.collider.tag == "BoardToComputer")
                {

                    Windows.m_Priority = 5;
                    Board.m_Priority = 5;
                    Computer.m_Priority = 20;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 5;


                    //SwitchFromBoardToWindows.SetActive(false);
                    //switchToboard.SetActive(true);

                    //Chair.Play();

                    //leftP.Play("Appear");
                    //rightP.Play("Fade");


                }
                else if (hit.collider != null && hit.collider.tag == "WindowsSwitch")
                {
                   
                    Windows.m_Priority = 20;
                    Board.m_Priority = 5;
                    Computer.m_Priority = 5;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 5;

                    WindowsSwitch1.SetActive(true);
                    WindowsSwitch2.SetActive(true);

                    phoneActivator.SetActive(false);

                    if (red == true)
                    {
                        ConversationManager.Instance.StartConversation(myConversation1);
                    }

                    //leftP.Play("Fade");
                    beforefirstcomputerinteraction = false;

                }
                else if (hit.collider != null && hit.collider.tag == "TelephoneSwitch")
                {
                    
                    Telephone.m_Priority = 20;
                    Board.m_Priority = 5;
                    Computer.m_Priority = 5;
                    Windows.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 5;

                    phoneActivator.SetActive(true);

                    //leftP.Play("Fade");
                    //rightP.Play("Stay");

                    
                }
                else if (hit.collider != null && hit.collider.tag == "ComputerTurnOn")
                {
                    if (red == true)
                    {
                        light.color = Color.green;
                        red = false;
                        computerWindows.OpenWindow();
                        AudioManager.PlaySetup();
                    }
                    else if (red == false)
                    {
                        light.color = Color.red;
                        red = true;
                        computerWindows.CloseWindow();
                        AudioManager.PlayTurnOff();
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "ActivatePhone")
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        phoneActivator.SetActive(false);
                        numbersCollider.SetActive(true);
                        
                        EnterNumberCanvas.SetActive(true);
                    }
                    
                }
                else if (hit.collider != null && hit.collider.tag == "ComputerShelf")
                {

                    Windows.m_Priority = 5;
                    Board.m_Priority = 5;
                    Computer.m_Priority = 5;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 20;
                    RoomShelf.m_Priority = 5;

                }
                else if (hit.collider != null && hit.collider.tag == "RoomShelf")
                {

                    Windows.m_Priority = 5;
                    Board.m_Priority = 5;
                    Computer.m_Priority = 5;
                    Telephone.m_Priority = 5;
                    CompShelf.m_Priority = 5;
                    RoomShelf.m_Priority = 20;

                }
                else if (hit.collider != null && hit.collider.tag == "num1" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "1";
                        num1.Play("Num1play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num2" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "2";
                        num2.Play("Num2play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num3" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "3";
                        num3.Play("Num3play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num4" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "4";
                        num4.Play("Num4play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num5" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "5";
                        num5.Play("Num5play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num6" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "6";
                        num6.Play("Num6play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num7" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "7";
                        num7.Play("Num7play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num8" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "8";
                        num8.Play("Num8play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num9" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "9";
                        num9.Play("Num9play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                else if (hit.collider != null && hit.collider.tag == "num0" && numberText.text.Length < 8)
                {
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        numberText.text += "0";
                        num0.Play("Num0play");
                        TelephoneButton.PlayOneShot(PhoneButton);
                    }
                }
                
            }
            
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(60f);
        if (beforefirstcomputerinteraction)
        {
            ConversationManager.Instance.StartConversation(myConversation2);
            timerwork = false;
        }
    }
}
