using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MuteMusic : MonoBehaviour
{
    public GameObject music;
    public GameObject button;
    public VideoPlayer videoPlayer;
    public void MusicMute()
    {
        music.SetActive(false);
        button.SetActive(false);
        videoPlayer.Play();
        StartCoroutine(Mute());
    }

    IEnumerator Mute()
    {
        yield return new WaitForSeconds(35f);
        music.SetActive(true);
        button.SetActive(true);
    }
}
