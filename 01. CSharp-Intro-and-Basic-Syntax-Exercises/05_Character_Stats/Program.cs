using System;

namespace _05_Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int curHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int curEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int numOfdotsHealth = maxHealth - curHealth;

            Console.WriteLine($"Health: |{new string('|',curHealth)}{new string('.', numOfdotsHealth)}|");

            int numOfDotsEnergy = maxEnergy - curEnergy;

            Console.WriteLine($"Energy: |{new string('|', curEnergy)}{new string('.', numOfDotsEnergy)}|");
            //  string energy = "|" + new string('|', curEnergy) + new string('.', numOfDotsEnergy) "|");
        }
    }
}
