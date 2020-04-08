﻿using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        //Set range of character to 2m from target within Unity
        //https://answers.unity.com/questions/282128/what-does-0f-and-5f-mean.html
        [SerializeField] float weaponRange = 2f;

        Transform target;

        //Update to be able to move to/attack existing targets
        public void Update()
        {
           //If target exists, move to that target
           if (target == null)
            {
                return;
            }
           if (!GetInRange())
           {
                GetComponent<Mover>().MoveTo(target.position);
           }
            else
            {
                GetComponent<Animator>().SetTrigger("attack");

            }

        }
        //Function to have player get in range of target
        private bool GetInRange()
        {
            //https://answers.unity.com/questions/1288414/move-player-to-exact-vector3-coordinates-beginner.html
            return Vector3.Distance(transform.position, target.position) < weaponRange;
        }

        public void Attack(CombatTarget combattarget)
        {
            print("Your mother was a hamster and your father smelt of elderberries.");

            //Set enemy to combat target
            target = combattarget.transform;
        }

        //Animation for hitting
        public void Hit()
        {

        }
    }
}