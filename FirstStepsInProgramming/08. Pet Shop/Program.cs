using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        const double DogFood = 2.50;
        const double CatFood = 4;
        static void Main(string[] args)
        {
            var numOfDogFood = int.Parse(Console.ReadLine());
            var numOfCatFood = int.Parse(Console.ReadLine());

            var dogFoodPrice = numOfDogFood * DogFood;
            var catFoodPrice = numOfCatFood * CatFood;

            var totalSum = dogFoodPrice + catFoodPrice;

            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
