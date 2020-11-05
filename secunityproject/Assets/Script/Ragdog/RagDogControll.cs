using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDogControll : MonoBehaviour
{
    public Animator Animator;
    public Rigidbody[] rigidbodies;

    private void Awake()
    {
        for (int i = 0; i < rigidbodies.Length; i++) {
            rigidbodies[i].isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            MakePhysical();
        }

    }

    private void MakePhysical()
    {
        Animator.enabled = false;
        for (int i = 0; i < rigidbodies.Length; i++) {
            rigidbodies[i].isKinematic = false;
        }
    }
}
