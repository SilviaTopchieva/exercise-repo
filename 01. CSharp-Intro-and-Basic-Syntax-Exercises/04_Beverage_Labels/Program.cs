using System;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double EnergyContent = double.Parse(Console.ReadLine());
            double SugarContent = double.Parse(Console.ReadLine());

            double energy = EnergyContent / 100 * volume;
            double sugar =  SugarContent / 100 * volume;

            Console.WriteLine($"{volume}ml {name}:\r\n{energy}kcal, {sugar}g sugars");
        }
    }
}
