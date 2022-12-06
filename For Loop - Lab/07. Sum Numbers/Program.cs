using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersOfDigits = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < numbersOfDigits; i++)
            {
                var digit = int.Parse(Console.ReadLine());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
