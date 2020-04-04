using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Know position of target
    [SerializeField] Transform target;
  

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
    }
}
