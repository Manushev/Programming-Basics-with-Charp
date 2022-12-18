using System;

namespace _03._New_House
{
    internal class Program
    {
        const double PricePerRoses = 5;
        const double PricePerDahlias = 3.80;
        const double PricePerTulips = 2.80;
        const double PricePerNarcissus = 3;
        const double PricePerGladiouls = 2.50;
        static void Main(string[] args)
        {
            var typeOfFlower = Console.ReadLine();
            var numOfFlowers = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());

            var discount = 0.0;
            var totalPrice = 0.0;

            switch (typeOfFlower)
            {
                case "Roses":
                    totalPrice = numOfFlowers * PricePerRoses;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.10;
                        totalPrice -= totalPrice * discount;
                    }
                    break;
                case "Dahlias":
                    totalPrice = numOfFlowers * PricePerDahlias;
                    if (numOfFlowers > 90)
                    {
                        discount = 0.15;
                        totalPrice -= totalPrice * discount;
                    }
                    break;
                case "Tulips":
                    totalPrice = numOfFlowers * PricePerTulips;
                    if (numOfFlowers > 80)
                    {
                        discount = 0.15;
                        totalPrice -= totalPrice * discount;
                    }
                    break;
                case "Narcissus":
                    totalPrice = numOfFlowers * PricePerNarcissus;
                    if (numOfFlowers < 120)
                    {
                        discount = 0.15;
                        totalPrice += totalPrice * discount;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = numOfFlowers * PricePerGladiouls;
                    if (numOfFlowers < 80)
                    {
                        discount = 0.20;
                        totalPrice += totalPrice * discount;
                    }
                    break;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeOfFlower} and {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            }
        }
    }
}
