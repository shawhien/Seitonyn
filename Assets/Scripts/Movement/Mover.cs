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
            UpdateAnimator();
        }

        //Apply Vector3 that hit.point requires
        //https://docs.unity3d.com/ScriptReference/Vector3.html
        public void MoveTo(Vector3 destination)
        {
            //Destination is command given and can be applied to NavMeshAgent.
            GetComponent<NavMeshAgent>().destination = destination;
        }
    }
    private void UpdateAnimator()
    {
        //Get the velocity from the NavMeshAgent
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;

        // https://docs.unity3d.com/ScriptReference/Transform.InverseTransformDirection.html
        //Take the global velocity and make it local. 
        //No matter where you are in the world, make the velocity local so the animator doesn't get confused.
        //Global values are irrelevant to the animator and returns an error
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
    }
}