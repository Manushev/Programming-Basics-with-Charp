using System;

namespace _06._Repainting
{
    internal class Program
    {
        const double NylonPrice = 1.50;
        const double PaintPrice = 14.50;
        const double PaintThinnerPrice = 5;
        const double BagsAmount = 0.40;
        static void Main(string[] args)
        {
            var nylon = int.Parse(Console.ReadLine()) + 2;
            var paint = int.Parse(Console.ReadLine());
            var thinner = int.Parse(Console.ReadLine());
            //The hours for which the craftsmen will complete the work
            var hours = int.Parse(Console.ReadLine());

            

            var nylonAmount = nylon * NylonPrice;
            var paintAmount = (paint + (paint * 0.10)) * PaintPrice;
            var thinnerAmount = thinner * PaintThinnerPrice;

            var totalSum = nylonAmount + paintAmount + thinnerAmount + BagsAmount;
            
            var moneyForCraftsmen = (totalSum * 0.30) * hours;
            var finalSum = totalSum + moneyForCraftsmen;

            Console.WriteLine(finalSum);
        }
    }
}
