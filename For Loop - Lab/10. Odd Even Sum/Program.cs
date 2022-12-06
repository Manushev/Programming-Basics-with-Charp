using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfDigits = int.Parse(Console.ReadLine());

            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < numberOfDigits; i++)
            {
                var digit = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
