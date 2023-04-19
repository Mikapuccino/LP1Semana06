using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;
        
        // Foe constructor, defines name, health and shield
        public Foe(string name)
        {
            this.name = SetName();
            health = 100;
            shield = 0;
        }

        // Returns the name of foe
        public string GetName()
        {
            return name;
        }

        // Returns the current health of foe
        public float GetHealth()
        {
            return health;
        }

        // Returns the current shield of foe
        public float GetShield()
        {
            return shield;
        }

        public string SetName()
        {
            Console.WriteLine("Choose the name of your foe: ");
            return Console.ReadLine();
        }
        
        // Reduces the Foe's health by the damage not blocked by shield
        public void TakeDamage(float damage)
        {
            // If shield isn't reduced to 0, Foe takes no damage
            shield -= damage;
            if (shield < 0)
            {
                // Health is reduced by damage not blocked by shield
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
    }
}