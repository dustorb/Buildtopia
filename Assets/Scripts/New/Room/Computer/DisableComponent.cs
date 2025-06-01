using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComponent : MonoBehaviour
{
    public PlayerMove PlayerMove;

    // Start is called before the first frame update
    public void disablecomp()
    {
        PlayerMove.enabled = false;
    }
}
