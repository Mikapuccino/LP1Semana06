using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many enemies will be created?");
            int nOfFoes = int.Parse(Console.ReadLine());

            Foe Foes = new Foe[nOfFoes];

            for (int i = 0; i < nOfFoes; i++)
            {
                Foe enemy = new Foe();
                Foes[i] = enemy;
            }

            for (int i = 0; i < nOfFoes; i++)
            {
                Console.WriteLine(i.name);
            }
        }
    }
}
