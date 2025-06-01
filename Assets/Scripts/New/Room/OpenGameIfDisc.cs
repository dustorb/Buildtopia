using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class OpenGameIfDisc : MonoBehaviour
{
    public GameObject gamewindow;
    public GameObject nogamewindow;
    public bool haveGameDisc;
    public bool haveDiscInComputer;
    public bool quest = true;

    public bool fixthegame = false;

    public QuestManager qmanager;

    [SerializeField] private NPCConversation myConversation1;
    [SerializeField] private NPCConversation myConversation2;

    [SerializeField] private NPCConversation fixedgamedialogue;

    public PlayerMove PlayerMove;

    public void OpenGame()
    {
        if (haveGameDisc && haveDiscInComputer)
        {
            gamewindow.SetActive(true);

            PlayerMove.enabled = true;

            if (quest)
            {
                qmanager.Quest0();
                quest = false;
            }
        }
        else if (!haveGameDisc && !haveDiscInComputer)
        {
            nogamewindow.SetActive(true);
            ConversationManager.Instance.StartConversation(myConversation1);
        }
        else if (haveGameDisc && !haveDiscInComputer)
        {
            nogamewindow.SetActive(true);
            ConversationManager.Instance.StartConversation(myConversation2);
        }
        else
        {
            nogamewindow.SetActive(true);
            ConversationManager.Instance.StartConversation(myConversation1);
        }

        if (fixthegame)
        {
            gamewindow.SetActive(true);
            ConversationManager.Instance.StartConversation(fixedgamedialogue);
        }
    }

}
