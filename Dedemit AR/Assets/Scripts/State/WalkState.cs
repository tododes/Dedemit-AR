using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : IDedemitState
{
    private Transform transform;
    private Animator animator;
    private float speed;

    public WalkState(float speed) {
        this.speed = speed;
    }

    public void doAction(Dedemit dedemit){
        if (!transform)
            transform = dedemit.transform;

        if (!animator)
            animator = dedemit.GetComponent<Animator>();

        if(!animator.isActiveAndEnabled)
            animator.enabled = true;

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
