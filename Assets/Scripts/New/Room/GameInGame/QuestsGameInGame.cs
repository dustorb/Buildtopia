using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using Unity.VisualScripting;

public class Quests : MonoBehaviour
{
    public bool applequest;
    public int apples;
    public ConversationStarter yagodkaDialogue;
    [SerializeField] private NPCConversation myConversation;
    public GameObject apple;
    public GameObject inventory;

    public GameObject sky1;
    public GameObject sky2;

    public void TakeAppleQuest()
    {
        applequest = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Apple" && applequest)
        {
            Destroy(other.gameObject);

            GameObject tab = (GameObject)Instantiate(apple);
            tab.transform.SetParent(inventory.transform);
            tab.transform.localScale = Vector2.one;
            tab.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            tab.transform.rotation = inventory.transform.rotation;

            apples += 1;
            if (apples == 5)
            {
                applequest = false;
                yagodkaDialogue.quest = true;
                foreach (Transform child in inventory.transform)
                {
                    Destroy(child.gameObject);
                }
                ConversationManager.Instance.StartConversation(myConversation);
                sky2.SetActive(true);
                sky1.SetActive(false);

            }
        }
    }
}
