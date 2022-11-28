using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basketballFee = int.Parse(Console.ReadLine());

            //Equipment
            var sneakersPrice = basketballFee - (basketballFee * 0.40);
            var clothingPrice = sneakersPrice - (sneakersPrice * 0.20);
            ;
            var ballPrice = clothingPrice / 4;
            var accessories = ballPrice / 5;

            var totalExpenses = basketballFee + sneakersPrice + clothingPrice + ballPrice + accessories;

            Console.WriteLine(totalExpenses);
        }
    }
}
