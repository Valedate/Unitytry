using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforceatpopint : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float Speed = 5f;
    public float RotSpeed = 1f;
    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * RotSpeed;
        float fowardForce = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(0f, 0f, fowardForce);
        _rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}
