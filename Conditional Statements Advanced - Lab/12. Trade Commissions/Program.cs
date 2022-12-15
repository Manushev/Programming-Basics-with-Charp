using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var salesVolume = double.Parse(Console.ReadLine());

            var result = 0.0;

            if (town is "Sofia")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    result = salesVolume * 0.05;
                }
                else if (salesVolume <= 1000)
                {
                    result = salesVolume * 0.07;
                }
                else if (salesVolume <= 10000)
                {
                    result = salesVolume * 0.08;
                }
                else if (salesVolume > 10000)
                {
                    result = salesVolume * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town is "Varna")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    result = salesVolume * 0.045;
                }
                else if (salesVolume <= 1000)
                {
                    result = salesVolume * 0.075;
                }
                else if (salesVolume <= 10000)
                {
                    result = salesVolume * 0.10;
                }
                else if (salesVolume > 10000)
                {
                    result = salesVolume * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town is "Plovdiv")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    result = salesVolume * 0.055;
                }
                else if (salesVolume <= 1000)
                {
                    result = salesVolume * 0.08;
                }
                else if (salesVolume <= 10000)
                {
                    result = salesVolume * 0.12;
                }
                else if (salesVolume > 10000)
                {
                    result = salesVolume * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (result != 0)
            {
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
