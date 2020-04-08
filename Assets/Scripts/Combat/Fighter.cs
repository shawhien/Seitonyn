﻿using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        //Set range of character to 2m from target within Unity
        //https://answers.unity.com/questions/282128/what-does-0f-and-5f-mean.html
        [SerializeField] float range = 2f;
        [SerializeField] float weaponDamage = 5f;
        [SerializeField] float timeBetweenAttacks = 1f;

        Transform target;
        float timeSinceAttack = 0;


        //Update to be able to move to/attack existing targets
        public void Update()
        {
            //https://docs.unity3d.com/ScriptReference/Time-deltaTime.html
            //https://answers.unity.com/questions/296336/timedeltatime.html
            timeSinceAttack += timeSinceAttack.deltaTime;
            //Check the distance between player position
            bool isInRange = Vector3.Distance(transform.position, target.position) < range;
           //If target exists, move to that target
           if (target != null && !isInRange)
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
                GetComponent<Animator>().SetTrigger("attack");
                Hit();

            }
        }

        //Animation for hitting
        public void Hit()
        {
            Health healthComponent = target.GetComponent<Health>();
            healthComponent.TakeDamage(weaponDamage);
        }

        //Function to have player get in range of target
        private bool GetInRange()
        {
            //https://answers.unity.com/questions/1288414/move-player-to-exact-vector3-coordinates-beginner.html
            return Vector3.Distance(transform.position, target.position) < range;
        }

        public void Attack(CombatTarget combattarget)
        {
            print("Your mother was a hamster and your father smelt of elderberries.");

            //Set enemy to combat target
            target = combattarget.transform;
        }

        ////Stop attacking when click to move (WiP)
        ////https://stackoverflow.com/questions/38057082/attack-timer-stops-after-killing-enemy-when-attack-script-loose-target-unity
        //public void Cancel()
        //{
        //    target = null;
        //}
    }

}