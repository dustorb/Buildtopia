using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartscript : MonoBehaviour
{
    public GameObject MusicCanvas;
    public GameObject Canvases;
    public GameObject ComputerCanvas;
    public GameObject BoardNotes;
    public GameObject CanvasDream;
    public GameObject TransSecvis;
    public string name;

    public void Restartgame()
    {
        MusicCanvas = GameObject.Find("MusicCanvas");
        Canvases = GameObject.Find("Canvases");
        ComputerCanvas = GameObject.Find("ComputerCanvas");
        BoardNotes = GameObject.Find("BoardNotes");
        CanvasDream = GameObject.Find("CanvasDream");
        TransSecvis = GameObject.Find("TransSecvis");

        if (MusicCanvas != null)
        {
            Destroy(GameObject.Find("MusicCanvas"));
        }

        if (Canvases != null)
        {
            Destroy(GameObject.Find("Canvases"));
        }

        if (ComputerCanvas != null)
        {
            Destroy(GameObject.Find("ComputerCanvas"));
        }

        if (BoardNotes != null)
        {
            Destroy(GameObject.Find("BoardNotes"));
        }

        if (CanvasDream != null)
        {
            Destroy(GameObject.Find("CanvasDream"));
        }

        if (TransSecvis != null)
        {
            Destroy(GameObject.Find("TransSecvis"));
        }

        SceneManager.LoadScene(name);
    }
}
