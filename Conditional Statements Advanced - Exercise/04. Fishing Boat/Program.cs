using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        //The cost of renting the vessel during the seasons.
        const int PricePerSpring = 3000;
        const int PricePerSummerAndAutumn = 4200;
        const int PricePerWinter = 2600;
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var numOfFishermen = int.Parse(Console.ReadLine());

            var discount = 0.0;
            var extraDiscount = 0.0;
            var totalPrice = 0.0;

            if (numOfFishermen <= 6)
            {
                discount = 0.10;
            }
            else if (numOfFishermen <= 11)
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }

            switch (season)
            {
                case "Spring":
                    totalPrice = PricePerSpring;
                    totalPrice -= totalPrice * discount;
                    break;
                case "Summer":
                    totalPrice = PricePerSummerAndAutumn;
                    totalPrice -= totalPrice * discount;
                    break;
                case "Autumn":
                    totalPrice = PricePerSummerAndAutumn;
                    totalPrice -= totalPrice * discount;
                    break;
                case "Winter":
                    totalPrice = PricePerWinter;
                    totalPrice -= totalPrice * discount;
                    break;
            }

            if (numOfFishermen % 2 == 0 && season != "Autumn")
            {
                extraDiscount = 0.05;
                totalPrice -= totalPrice * extraDiscount;
            }

            if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
            }
        }
    }
}
