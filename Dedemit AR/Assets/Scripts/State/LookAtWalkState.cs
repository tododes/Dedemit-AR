using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtWalkState : IDedemitState {

    private Transform target;
    private Transform transform;
    private Animator animator;
    private float speed;
    private Vector3 desiredEulerAngles;

    public LookAtWalkState(Transform target, float speed) {
        this.target = target;
        this.speed = speed;
        desiredEulerAngles = Vector3.zero;
    }

    public void doAction(Dedemit dedemit) {
        if (!transform)
            transform = dedemit.transform;

        transform.LookAt(target);
        desiredEulerAngles.y = transform.eulerAngles.y;
        transform.eulerAngles = desiredEulerAngles;
    }
}
