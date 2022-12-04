using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        const double FilmDecor = 0.10; //%
        const double Discount = 0.10; //%
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var extras = int.Parse(Console.ReadLine());
            var pricePerClothes = double.Parse(Console.ReadLine());

            var decor = budget * FilmDecor;

            var clothesPrice = extras * pricePerClothes; 

            if (extras > 150)
            {
                clothesPrice -= clothesPrice * Discount;
            }

            var totalBudgetPerFilm = clothesPrice + decor;

            if (totalBudgetPerFilm > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalBudgetPerFilm - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalBudgetPerFilm:F2} leva left.");
            }
        }
    }
}
