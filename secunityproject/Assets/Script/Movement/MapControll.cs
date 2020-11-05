using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControll : MonoBehaviour
{
    // Move object using accelerometer
    float rotspeed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.forward * Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.forward * Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * rotspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * rotspeed * Time.deltaTime);
    }
}

