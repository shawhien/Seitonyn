using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        //Set range of character from target
        //[SerializeField] float weaponRange = 2f;

        //Transform target;

        //public void Update()
        //{
        //    //If target exists, move to that target
        //    if (enemy != null)
        //    {
        //        GetComponent<Mover>().MoveTo(enemy.position);
        //    }
        //}

        public void Attack(CombatTarget target)
        {
            print("Your mother was a hamster and your father smelt of elderberries.");

            //enemy = target.transform;
        }
    }
}