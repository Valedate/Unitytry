using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phisics : MonoBehaviour
{
    public Collider ColiderA;
    public Collider ColiderB;
    void Start()
    {
        Physics.IgnoreCollision(ColiderA, ColiderB);
    }

  
}
