﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
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
}