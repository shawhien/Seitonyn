using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        //Raycast from camera to left mouse-click location
        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }
  
}
