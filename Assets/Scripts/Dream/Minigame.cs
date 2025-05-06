using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    [Header("cam")]
    public Camera cam;
    [Header("NotTurn")]
    public GameObject blackNotTurn;
    public GameObject redNotTurn;
    public GameObject blueNotTurn;
    public GameObject greenNotTurn;
    [Header("Turn")]
    public GameObject blackTurn;
    public GameObject redTurn;
    public GameObject blueTurn;
    public GameObject greenTurn;
    [Header("Dialoue")]
    public Commentaryactivatortofinroom ConnectedDialogueActivator;
    public Commentaryactivatortofinroom NotConnectedDialogueActivator;

    // checking
    public bool blackGet;
    public bool redGet;
    public bool blueGet;
    public bool greenGet;

    // checking
    public bool redTrue;
    public bool blackTrue;
    public bool blueTrue;
    public bool greenTrue;


    public bool connection;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.tag == "blackNotTurn")
                {
                    blackGet = true;
                    redGet = false;
                    blueGet = false;
                    greenGet = false;
                }
                else if (hit.collider != null && hit.collider.tag == "redNotTurn")
                {
                    redGet = true;
                    blackGet = false;
                    blueGet = false;
                    greenGet = false;
                }
                else if (hit.collider != null && hit.collider.tag == "blueNotTurn")
                {
                    redGet = false;
                    blackGet = false;
                    blueGet = true;
                    greenGet = false;
                }
                else if (hit.collider != null && hit.collider.tag == "greenNotTurn")
                {
                    blackGet = false;
                    redGet = false;
                    blueGet = false;
                    greenGet = true;
                }
                else if (hit.collider != null && redGet == true)
                {
                    if (hit.collider.tag == "redCell")
                    {
                        redNotTurn.SetActive(false);
                        Instantiate(redTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        redTrue = true;
                        redGet = false;
                    }
                    else if (hit.collider.tag == "Cell" || hit.collider.tag == "blueCell" || hit.collider.tag == "greenCell" || hit.collider.tag == "blackCell")
                    {
                        redNotTurn.SetActive(false);
                        Instantiate(redTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        redGet = false;
                    }
                }
                else if (hit.collider != null && blackGet == true)
                {
                    if (hit.collider.tag == "blackCell")
                    {
                        blackNotTurn.SetActive(false);
                        Instantiate(blackTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        blackTrue = true;
                        blackGet = false;
                    }
                    else if (hit.collider.tag == "Cell" || hit.collider.tag == "blueCell" || hit.collider.tag == "redCell" || hit.collider.tag == "greenCell")
                    {
                        blackNotTurn.SetActive(false);
                        Instantiate(blackTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        blackGet = false;
                    }
                }
                else if (hit.collider != null && blueGet == true)
                {
                    if (hit.collider.tag == "blueCell")
                    {
                        blueNotTurn.SetActive(false);
                        Instantiate(blueTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        blueTrue = true;
                        blueGet = false;
                    }
                    else if (hit.collider.tag == "Cell" || hit.collider.tag == "blackCell" || hit.collider.tag == "redCell" || hit.collider.tag == "greenCell")
                    {
                        blueNotTurn.SetActive(false);
                        Instantiate(blueTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        blueGet = false;
                    }
                }
                else if (hit.collider != null && greenGet == true)
                {
                    if (hit.collider.tag == "greenCell")
                    {
                        greenNotTurn.SetActive(false);
                        Instantiate(greenTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        greenTrue = true;
                        greenGet = false;
                    }
                    else if (hit.collider.tag == "Cell" || hit.collider.tag == "blueCell" || hit.collider.tag == "redCell" || hit.collider.tag == "blackCell")
                    {
                        greenNotTurn.SetActive(false);
                        Instantiate(greenTurn, hit.collider.gameObject.transform.position, hit.collider.gameObject.transform.rotation);
                        greenGet = false;
                    }
                }
                if (hit.collider != null && hit.collider.tag == "TurnRedCab")
                {
                    Destroy(hit.collider.gameObject);
                    redTrue = false;
                    redNotTurn.SetActive(true);
                }
                else if (hit.collider != null && hit.collider.tag == "TurnBlackCab")
                {
                    blackNotTurn.SetActive(true);
                    blackTrue = false;
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider != null && hit.collider.tag == "TurnBlueCab")
                {
                    blueNotTurn.SetActive(true);
                    blueTrue = false;
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider != null && hit.collider.tag == "TurnGreenCab")
                {
                    greenNotTurn.SetActive(true);
                    greenTrue = false;
                    Destroy(hit.collider.gameObject);
                }


                if (redTrue && greenTrue && blueTrue && blackTrue && !connection)
                {
                    ConnectedDialogueActivator = GameObject.Find("ConnectedDialogue").GetComponent<Commentaryactivatortofinroom>();
                    ConnectedDialogueActivator.StartingMonologue();
                    connection = true;
                }
                else if (!greenNotTurn.activeSelf && !redNotTurn.activeSelf && !blueNotTurn.activeSelf && !blackNotTurn.activeSelf && !connection)
                {
                    NotConnectedDialogueActivator = GameObject.Find("NotConnectedDialogue").GetComponent<Commentaryactivatortofinroom>();
                    NotConnectedDialogueActivator.StartingMonologue();
                    connection = true;
                }
            }
        }
    }
}
