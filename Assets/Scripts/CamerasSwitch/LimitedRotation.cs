using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedRotation : MonoBehaviour
{
    public float speedV = 2.0f;
    public float speedH = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    // Update is called once per frame
    void Update()
    {
        rotationY += speedV * Input.GetAxis("Mouse X");
        rotationX -= speedV * Input.GetAxis("Mouse Y");

        rotationX = Mathf.Clamp(rotationX, minX, maxX);
        rotationY = Mathf.Clamp(rotationY, minY, maxY);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
