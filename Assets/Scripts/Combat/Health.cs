using UnityEngine;


namespace RPG.combat
{
    public class Health: MonoBehaviour
    {
        //set initial health to 100 float.
        [SerializeField] float health = 100f;

        public void TakeDamage(float damage)
        {
            //Health cannot go below 0
            //https://forum.unity.com/threads/how-to-make-an-integer-not-go-below-0.149183/
            health = Mathf.Max(health - damage, 0);
            print(health);
        }
    }
}


