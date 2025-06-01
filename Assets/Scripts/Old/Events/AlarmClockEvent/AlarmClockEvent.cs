using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlarmClockEvent : MonoBehaviour
{
    public TMP_Text alarmTime;
    public TMP_Text Timer;
   
    void OnEnable()
    {
        alarmTime.text = Timer.text;
    }
}
