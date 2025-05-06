using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAlarmClockEvent : MonoBehaviour
{
    public GameObject Alarm;
    public ChangeHierarchyWindows ChangeHierarchyWindows;

    public AudioSource alarmsound;
   

    public void StartAlarmEvent()
    {
        StartCoroutine(AlarmEvent());
    }

    IEnumerator AlarmEvent()
    {
        yield return new WaitForSeconds(30f);
        Alarm.SetActive(true);
        alarmsound.Play();
        ChangeHierarchyWindows.HigherInHierarchy();
    }
}
