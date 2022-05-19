using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour 
    {
        [SerializeField]
        float health = 100f;  
        bool isDeath = false;

        public bool IsDeath()
        {
            return isDeath;
        }
        
        public void TakeDamage(float damage)
        {
            health = Mathf.Max(health - damage, 0);
            if (health == 0)
            {
                Die();
            }

        }

        private void Die()
        {
            if (isDeath)
                return;
            
            isDeath = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}