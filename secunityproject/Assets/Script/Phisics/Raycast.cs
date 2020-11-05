using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public float distance;
    public Transform Pointer;
    public Selecteble CurrentSelecteble;
    public LayerMask layerMask;

    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;

            Selecteble selecteble = hit.collider.gameObject.GetComponent<Selecteble>();
            if (selecteble)  {
                if (CurrentSelecteble && CurrentSelecteble != selecteble) {
                    CurrentSelecteble.DeSelected();
                    CurrentSelecteble = null;

                }
                CurrentSelecteble = selecteble;
                selecteble.Select();
            }
            else
            {
                if (CurrentSelecteble)
                {
                    CurrentSelecteble.DeSelected();
                    CurrentSelecteble = null;
                }
            }

        }
        else {
            if (CurrentSelecteble) {
                CurrentSelecteble.DeSelected();
                CurrentSelecteble = null;
            }
}

    }
    }



