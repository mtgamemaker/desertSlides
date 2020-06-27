using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        anim.SetInteger("jumpState", 1);
    }
}
