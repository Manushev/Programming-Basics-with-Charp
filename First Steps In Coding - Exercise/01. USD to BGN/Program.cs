using System;

namespace _01._USD_to_BGN
{
    internal class Program
    {
        const double BgnFixedRatePerUsd = 1.79549;
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());

            var bgn = usd * BgnFixedRatePerUsd;

            Console.WriteLine(bgn);
        }
    }
}
