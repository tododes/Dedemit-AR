using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IDedemitState
{
    private Animator animator;

    public void doAction(Dedemit dedemit){
        if (!animator)
            animator = dedemit.GetComponent<Animator>();

        animator.enabled = false;
    }
}
