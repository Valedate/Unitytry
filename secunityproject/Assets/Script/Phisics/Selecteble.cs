using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecteble : MonoBehaviour
{
    // Start is called before the first frame update
    public void Select() {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void DeSelected() {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
