using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        const double PackOfPencil = 5.80;
        const double PackOfMarkers = 7.20;
        const double PreparationPerLiter = 1.20;
        static void Main(string[] args)
        {
            var numOfPacketsPencils = int.Parse(Console.ReadLine());
            var numOfPacketsMarkers = int.Parse(Console.ReadLine());
            var litersPreparation = int.Parse(Console.ReadLine());
            var discount = int.Parse(Console.ReadLine());

            var pricePencils = numOfPacketsPencils * PackOfPencil;
            var priceMarkers = numOfPacketsMarkers * PackOfMarkers;
            var pricePreparation = litersPreparation * PreparationPerLiter;

            var total = pricePencils + priceMarkers + pricePreparation;
            
            var discountMoney = total * (discount * 1.0 / 100);

            var finalMoney = total - discountMoney;

            Console.WriteLine(finalMoney);
        }
    }
}
