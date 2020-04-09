using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Got a lot of help with this section
// https://learn.unity.com/tutorial/interfaces?signup=true#
//Only methods and properties can be applied. A contract between methods/properties
namespace RPG.Core
{
    //https://docs.unity3d.com/Packages/com.unity.ai.planner@0.1/api/Unity.AI.Planner.IActionKey.html
    //Interface vs Classes: https://www.youtube.com/watch?v=kYJRIWjoeFA

    public interface IAction
    {
        void Cancel();
    }

}