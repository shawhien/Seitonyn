using UnityEngine;
using RPG.Movement;
using RPG.Combat;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        //Update functions every frame.(Created by Unity)
        private void Update()
        {
            //ctrl + . to automatically create function below
            if (CombatInteraction())
            {
                return;
            }
            if (MovementInteraction())
            {
                return;
            }
        }

        private bool CombatInteraction()
        {
            //option 8/8. returns all the things that get hit in an array.
            //https://docs.unity3d.com/ScriptReference/Physics.RaycastAll.html
            RaycastHit[] hits = Physics.RaycastAll(GetMouseRay());
            //Return a list of each hit foreach hit
            foreach (RaycastHit hit in hits)
            {
                CombatTarget target = hit.transform.GetComponent<CombatTarget>();

                //if target is null, then skip this part and move on with loop (continue)
                if (target == null) continue;
                {

                }
                //only happens if target is NOT null
                if (Input.GetMouseButtonDown(1))
                {
                    GetComponent<Fighter>().Attack(target);
                }
                //In combat, trigger combat interactions
                return true;                  
            }
            //not in combat. No targets to itneract with
            return false;
        }

        private bool MovementInteraction()
        {
            //https://docs.unity3d.com/ScriptReference/RaycastHit.html
            RaycastHit hit;
            //when hasHit is true, store position of raycast in (out) hit.
            bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
            //if it has something to hit, return true. If not, return false
            if (hasHit)
            {
                //Raycast from camera to left mouse-click location
                if (Input.GetMouseButtonDown(1))
                {
                //Be able to Raycast to components, not just terrain
                GetComponent<Mover>().MoveTo(hit.point);
                }
                return true;
            }
            return false;
        }

        private static Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }

    }
}