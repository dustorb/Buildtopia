using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTab : MonoBehaviour
{
    public GameObject tab;

    public void DestroyWindow()
    {
        Destroy(tab);
    }

}
