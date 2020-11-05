using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Thehand;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _rigidbody.AddForce(Vector3.forward * 30f, ForceMode.Impulse);
        }
    }
    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = Thehand.position;
        transform.parent = GameObject.Find("Hand").transform;
    }
    void OnMouseUp()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
    }

}
