using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        const double Puzzle = 2.60;
        const double Dolls = 3;
        const double Bear = 4.10;
        const double Minions = 8.20;
        const double Trucks = 2;
        static void Main(string[] args)
        {
            var excursion = double.Parse(Console.ReadLine());
            var puzzle = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var bear = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            var toyCount = puzzle + dolls + bear + minions + trucks;
            var toyMoney = (puzzle * Puzzle)
                + (dolls * Dolls)
                + (bear * Bear)
                + (minions * Minions)
                + (trucks * Trucks);

            if (toyCount >= 50)
            {
                toyMoney -= toyMoney * 0.25;
            }

            toyMoney -= toyMoney * 0.10;

            if (toyMoney >= excursion)
            {
                Console.WriteLine($"Yes! {toyMoney - excursion:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursion - toyMoney:F2} lv needed.");
            }
        }
    }
}
