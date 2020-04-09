using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    //Got a lot of help for this section
    //Use Substitution Principle to remove dependencies, thus reducing chance of bugs.
    public class Actions : MonoBehaviour
    {

        MonoBehaviour currentAction;

        //Cancel the movement when combat starts, and cancel combat when movement starts
        public void StartAction(MonoBehaviour action)
        {
            print("Cancelling" + currentAction);
            currentAction = action;
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

}