using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        const double PricePerSquareMeter = 7.61;
        const double Discount = 0.18;
        static void Main(string[] args)
        {
            var squareMeters = double.Parse(Console.ReadLine());

            var landscapingPrice = squareMeters * PricePerSquareMeter;

            var landscapingDiscount = landscapingPrice * Discount;

            var totalPrice = landscapingPrice - landscapingDiscount;

            Console.WriteLine($"The final price is: {totalPrice} lv.");
            Console.WriteLine($"The discount is: {landscapingDiscount} lv.");
        }
    }
}
