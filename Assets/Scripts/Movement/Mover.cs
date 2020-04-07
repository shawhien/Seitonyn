using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;

        // Update is called once per frame
        void Update()
        {
       
        }

        //Apply Vector3 that hit.point requires
        //https://docs.unity3d.com/ScriptReference/Vector3.html
        public void MoveTo(Vector3 destination)
        {
            //Destination is command given and can be applied to NavMeshAgent.
            GetComponent<NavMeshAgent>().destination = destination;
        }
    }
}