using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    public bool quest;

    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private NPCConversation myConversation1;
    [SerializeField] private NPCConversation myConversation2;
    [SerializeField] private NPCConversation myConversation3;

    public SaveAndLoadRoute SaveAndLoadRoute;
    private bool cantalk;

    public void questtrue()
    {
        quest = true;
    }
    public void Update()
    {
        if (cantalk)
        {
            if (!quest && SaveAndLoadRoute.Route1 == 0)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(myConversation);
                }
            }
            else if (SaveAndLoadRoute.Route1 == 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(myConversation2);
                }
            }

            if (quest && SaveAndLoadRoute.Route1 == 0)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(myConversation1);
                }
            }
            else if (quest && SaveAndLoadRoute.Route1 == 1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ConversationManager.Instance.StartConversation(myConversation3);
                }
            }
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        cantalk = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        cantalk = false;
    }
}
