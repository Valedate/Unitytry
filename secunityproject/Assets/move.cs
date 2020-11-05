using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    public new GameObject gameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.IsGameStarted)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
        }
    }
}
