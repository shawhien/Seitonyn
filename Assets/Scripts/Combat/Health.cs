using UnityEngine;


namespace RPG.Combat
{
    public class Health: MonoBehaviour
    {
        //set initial health to 100 float.
        [SerializeField] float healthPoints = 20f;

        bool isDead = false;

        public void TakeDamage(float damage)
        {
            //Health cannot go below 0
            //https://forum.unity.com/threads/how-to-make-an-integer-not-go-below-0.149183/
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            if (healthPoints == 0)
            {
                Die();
            }
            print(healthPoints);
        }

        private void Die()
        {
            if (isDead)
            {
                return;
            }

            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
           
    }
}


