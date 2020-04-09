using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using RPG.Combat;
using RPG.Core;

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

        public void StartAction(Vector3 destination)
        {
            //Same as Fighter.cs
            //Start action, cancel when appropriate, and move to the destination that is clicked
            GetComponent<Actions>().StartAction(this);
            GetComponent<Fighter>().Cancel();
            MoveTo(destination);
        }

        //Apply Vector3 that hit.point requires
        //https://docs.unity3d.com/ScriptReference/Vector3.html
        public void MoveTo(Vector3 destination)
        {
            //Destination is command given and can be applied to NavMeshAgent.
            GetComponent<NavMeshAgent>().destination = destination;
            GetComponent<NavMeshAgent>().isStopped = false;
        }

        //Stop the NavMeshAgent so that Player can stop before the object
        public void Cancel()
        {
            //https://docs.unity3d.com/ScriptReference/AI.NavMeshAgent-isStopped.html
            //https://answers.unity.com/questions/1355590/navmeshagentisstopped-true-but-is-still-moving.html
            GetComponent<NavMeshAgent>().isStopped = true;
        }

        private void UpdateAnimator()
        {
            //Get the velocity from NavMeshAgent
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;

            //https://docs.unity3d.com/ScriptReference/Transform.InverseTransformDirection.html
            //https://answers.unity.com/questions/506740/i-need-help-understanding-transformdirection.html
            //Global values are irrelevant to the animator. Make it local.

            Vector3 localVelocity = transform.InverseTransformDirection(velocity);

            //Only moving in Z direction, set that number equal to a variable.
            float speed = localVelocity.z;

            //Apply all of this to IdleWalkRun in the animator on Unity
            GetComponent<Animator>().SetFloat("IdleWalkRun", speed);
        }
    }      
}
