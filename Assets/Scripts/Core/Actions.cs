using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    //Got a lot of help for this section
    //Use Substitution Principle to remove dependencies, thus reducing chance of bugs.
    //http://gameprogrammingpatterns.com/component.html
    public class Actions : MonoBehaviour
    {

        IAction currentAction;

        //Cancel the movement when combat starts, and cancel combat when movement starts
        public void StartAction(IAction action)
        {
            //If current action is happening, no need to cancel. Just keep going.
            if (currentAction == action)
            {
                return;
            }
            //If current action is not null, then cancel action.
            if (currentAction != null)
            {

                currentAction.Cancel();

            }

            currentAction = action;
        
        }
    }

}