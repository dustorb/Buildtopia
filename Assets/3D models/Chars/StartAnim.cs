using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator.Play("Idle");
    }
}
