using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangatPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody TargetRigidbody;
    public float ForceValue = 100f;

    // Update is called once per frame
    public ParticleSystem ParticleSystem;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            TargetRigidbody.AddForceAtPosition(transform.up * ForceValue, transform.position);
            ParticleSystem.Play();
        }
    }
}
