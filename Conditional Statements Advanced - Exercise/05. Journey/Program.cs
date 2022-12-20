using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var totalPrice = 0.0;
            var typeOfRest = string.Empty;
            var destination = string.Empty;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.30;
                    typeOfRest = "Camp";
                }
                else if (season == "winter")
                {
                    totalPrice = budget * 0.70;
                    typeOfRest = "Hotel";
                }
                destination = "Bulgaria";
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfRest} - {totalPrice:F2}");
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    totalPrice = budget * 0.40;
                    typeOfRest = "Camp";
                }
                else if (season == "winter")
                {
                    totalPrice = budget * 0.80;
                    typeOfRest = "Hotel";
                }
                destination = "Balkans";
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfRest} - {totalPrice:F2}");
            }
            else
            {
                totalPrice = budget * 0.90;
                destination = "Europe";
                typeOfRest = "Hotel";

                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfRest} - {totalPrice:F2}");
            }
        }
    }
}
