using System;

namespace _01._Cinema
{
    internal class Program
    {
        const double Premiere = 12;
        const double Normal = 7.50;
        const double Discount = 5;
        static void Main(string[] args)
        {
            var typeOfProject = Console.ReadLine();
            var numOfRow = int.Parse(Console.ReadLine());
            var numOfColumn = int.Parse(Console.ReadLine());

            var income = 0.0;

            switch (typeOfProject)
            {
                case "Premiere":
                    income = (numOfRow * numOfColumn) * Premiere;
                    break;
                case "Normal":
                    income = (numOfRow * numOfColumn) * Normal;
                    break;
                case "Discount":
                    income = (numOfRow * numOfColumn) * Discount;
                    break;
            }

            Console.WriteLine($"{income:F2}");
        }
    }
}
