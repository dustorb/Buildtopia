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
        textHolder.text = "����� � ����";
    }

    public void Quest2()
    {
        textHolder.text = "����� ����";
    }

    public void Quest3()
    {
        textHolder.text = "�������� ����";
    }

    public void Quest4()
    {
        textHolder.text = "�������� ����";
    }
}
