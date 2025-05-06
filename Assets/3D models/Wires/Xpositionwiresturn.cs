using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xpositionwiresturn : MonoBehaviour
{
    public float n;

    void Start()
    {
        transform.localPosition = new Vector3(transform.localPosition.x - n, transform.localPosition.y, transform.localPosition.z);

    }
}
