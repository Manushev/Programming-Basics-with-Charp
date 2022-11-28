using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        const double PricePerChickenMenu = 10.35;
        const double PricePerFishMenu = 12.40;
        const double PricePerVegetarianMenu = 8.15;
        const double PricePerDelivery = 2.50;
        static void Main(string[] args)
        {
            var quantityOfChickenMenu = int.Parse(Console.ReadLine());
            var quantityOfFishMenu = int.Parse(Console.ReadLine());
            var quantityOfVegetarianMenu = int.Parse(Console.ReadLine());

            var pricePerFood = (quantityOfChickenMenu * PricePerChickenMenu) 
                + (quantityOfFishMenu * PricePerFishMenu)
                + (quantityOfVegetarianMenu * PricePerVegetarianMenu);

            var pricePerDessert = pricePerFood * 0.20;

            var totalSum = pricePerFood + pricePerDessert + PricePerDelivery;

            Console.WriteLine(totalSum);
        }
    }
}
