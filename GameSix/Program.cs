using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many enemies will be created?");
            int nOfFoes = int.Parse(Console.ReadLine());

            var Foes = new Foe[nOfFoes];

            for (int i = 0; i < nOfFoes; i++)
            {
                Foe enemy = new Foe();
                Foes[i] = enemy;
            }

            for (int i = 0; i < nOfFoes; i++)
            {
                Console.WriteLine($"Foe " + (i + 1) + " is called " +
                Foes[i].GetName() + ".");
            }

            Foes[0].PickupPowerUp(PowerUp.Shield, 10);
            Console.WriteLine("Foe 1 gained 10 shield.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetHealth() + " health.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetShield() + " shield.");

            Foes[0].TakeDamage(15);
            Console.WriteLine("Foe 1 took 15 damage, losing 5 health.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetHealth() + " health.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetShield() + " shield.");

            Foes[0].PickupPowerUp(PowerUp.Health, 2);
            Console.WriteLine("Foe 1 gained 2 health.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetHealth() + " health.");
            Console.WriteLine($"Foe 1 has " + Foes[0].GetShield() + " shield.");

            // Should be 2 powerups
            Console.WriteLine($"Foe 1 got " + Foe.GetPowerUp() +
            " powerups.");

            Console.WriteLine("Merci d'utiliser ce programme!");
        }
    }
}
