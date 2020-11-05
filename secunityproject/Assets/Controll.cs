using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controll : MonoBehaviour
{

    HingeJoint hinge;
    JointMotor motor;
    Rigidbody _rigidbody;

    public new GameObject gameObject;
    bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        hinge = gameObject.GetComponent<HingeJoint>();

        var motor = hinge.motor;
        motor.targetVelocity = 5;
        motor.force = 5;
        hinge.motor = motor;
        hinge.useMotor = true;
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            StartCoroutine(HandleIt());
            started = true;
        }
    }
    private IEnumerator HandleIt()
    {
        yield return new WaitForSeconds(2.0f);
        motor.force = 0;
        hinge.motor = motor;
    }
}
