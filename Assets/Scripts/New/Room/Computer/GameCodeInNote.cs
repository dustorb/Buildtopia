using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DialogueEditor;using UnityEngine.ProBuilder.Shapes;


public class GameCodeInNote : MonoBehaviour
{
    public TMP_InputField input;
    public bool quest;
    [SerializeField] private NPCConversation Conv1;
    [SerializeField] private NPCConversation Conv2;
    [SerializeField] private NPCConversation Conv3;    public GameObject sky1;    public GameObject sky2;    public OpenGameIfDisc OpenGameIfDisc;
    private void Awake()
    {
        input.text = "[\"!!!!!DIALOGUE SYSTEM!!!!!\"]}\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n";
    }

    // Start is called before the first frame update
    public void CodeQuestFalse()
    {
        quest = false;
    }

    public void CodeQuestTrue()
    {
        quest = true;
    }


    // Update is called once per frame
    public void ChangeText()
    {
        if (quest)
        {
            if (input.text == "[\"!!!!!DIALOGUE SYSTEM!!!!!\"]}\r\n")
            {
                ConversationManager.Instance.StartConversation(Conv2);
                OpenGameIfDisc.fixthegame = true;
                sky2.SetActive(false);
                sky1.SetActive(true);
            }
            else
            {
                ConversationManager.Instance.StartConversation(Conv3);
            }

            
        }
        else if (!quest)
        {
            if (input.text != "[\"!!!!!DIALOGUE SYSTEM!!!!!\"]}\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n")
            {
                ConversationManager.Instance.StartConversation(Conv1);
            }

        }
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.RightControl) && Input.GetKeyDown(KeyCode.Z))
        //{
        //    input.text = "код код код удалить";
        //}

        if (Input.GetKeyDown(KeyCode.Z))
        {
            input.text = "[\"!!!!!DIALOGUE SYSTEM!!!!!\"]}\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n\r\n{\"@c\":2367,\"@a\":[\"Посмотри на небо.\"]},\"@c\":2366},{\"code\":122,\"indent\":5,\"parameters\":{\"@c\":2369,\"@a\":[18,18,0,0,1]},\"@c\":2368},{\"code\":0,\"indent\":5,\"parameters\":{\"@c\":2371,\"@a\":[]},\"@c\":2370},{\"code\":411,\"indent\":4,\"parameters\":{\"@c\":2373,\"@a\":[]},\"@c\":2372}\r\n";
        }
    }
}
