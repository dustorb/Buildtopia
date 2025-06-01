using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public TextMeshProUGUI textHolder;

    public void Quest0()
    {
        textHolder.text = "";
    }

    public void Quest1()
    {
        textHolder.text = "Зайти в игру";
    }

    public void Quest2()
    {
        textHolder.text = "Найти диск";
    }

    public void Quest3()
    {
        textHolder.text = "Вставить диск";
    }

    public void Quest4()
    {
        textHolder.text = "Починить игру";
    }
}
