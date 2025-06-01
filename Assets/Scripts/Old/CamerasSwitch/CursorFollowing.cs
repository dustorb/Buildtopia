using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollowing : MonoBehaviour
{
    public Camera cam;
    private Vector3 screenPosition;
    private Vector3 worldPosition;

   

    // Update is called once per frame
    void Update()
    {
        screenPosition = Input.mousePosition;
        screenPosition.z = cam.nearClipPlane + 1;
        worldPosition = cam.ScreenToWorldPoint(screenPosition);
        transform.position = worldPosition;
    }
}
