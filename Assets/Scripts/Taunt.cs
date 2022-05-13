using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Taunt : NetworkBehaviour
{
    [SerializeField] private Animator animator;

    private void Update()
    {
        if(!isLocalPlayer) return;
        
        if(Input.GetKey(KeyCode.A)) animator.SetBool("T1",true);
        else animator.SetBool("T1",false);
        
        if(Input.GetKey(KeyCode.E)) animator.SetBool("T2",true);
        else animator.SetBool("T2",false);
    }
}
