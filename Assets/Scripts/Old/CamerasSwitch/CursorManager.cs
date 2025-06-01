using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] public Texture2D cursorTexture1;
    [SerializeField] public Texture2D cursorTexture2;
    [SerializeField] public Texture2D ComputercursorTexture1;
    [SerializeField] public Texture2D ComputercursorTexture2;
    private Vector2 cursorHotspot;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2(cursorTexture2.width / 2, cursorTexture2.height / 2);
        Cursor.SetCursor(cursorTexture2, cursorHotspot, CursorMode.Auto);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "ComputerSwitch" || hit.collider.tag == "BoardSwitch" || hit.collider.tag == "WindowsSwitch" || hit.collider.tag == "TelephoneSwitch" || hit.collider.tag == "BookSwitch" || hit.collider.tag == "ComputerTurnOn")
            {
                cursorHotspot = new Vector2(cursorTexture1.width / 2, cursorTexture1.height / 2);
                Cursor.SetCursor(cursorTexture1, cursorHotspot, CursorMode.Auto);
            }
            else if (hit.collider.tag == "ComputerWindow")
            {
                cursorHotspot = new Vector2(ComputercursorTexture1.width / 2, ComputercursorTexture1.height / 2);
                Cursor.SetCursor(ComputercursorTexture1, cursorHotspot, CursorMode.Auto);
            }
            else if (hit.collider.tag == "ComputerWindowInteractiveObject")
            {
                cursorHotspot = new Vector2(ComputercursorTexture2.width / 2, ComputercursorTexture2.height / 2);
                Cursor.SetCursor(ComputercursorTexture2, cursorHotspot, CursorMode.Auto);
            }
            else
            {
                cursorHotspot = new Vector2(cursorTexture2.width / 2, cursorTexture2.height / 2);
                Cursor.SetCursor(cursorTexture2, cursorHotspot, CursorMode.Auto);
            }
        }
    }
}
