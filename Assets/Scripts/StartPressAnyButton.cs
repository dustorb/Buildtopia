using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPressAnyButton : MonoBehaviour
{
    public Animator StartLogo;
    public Animator Name;
    public Animator PressButton;
    public bool CanPress;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PressAnyButton());
    }

    // Update is called once per frame
    void Update()
    {
        if (CanPress)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
            {
                
                StartLogo.Play("Play");
                Name.Play("Play");
                PressButton.Play("Play");
                CanPress = false;
            }
        }
    }

    IEnumerator PressAnyButton()
    {
        yield return new WaitForSeconds(8f);
        CanPress = true;
    }
}
