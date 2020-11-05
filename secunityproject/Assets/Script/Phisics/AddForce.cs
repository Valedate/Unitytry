using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-15, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(15, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(0f, 355f, 0f);
        }
    }
}
