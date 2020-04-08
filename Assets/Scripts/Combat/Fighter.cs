using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        //Be able to set range from target in Player Inspector in Unity
        //https://answers.unity.com/questions/1455929/how-can-i-use-the-range-attribute-on-a-serializabl.html
        [SerializeField] float weaponRange = 2f;

        //Transform enemy;

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