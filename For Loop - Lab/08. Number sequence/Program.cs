using System;
using System.Linq;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersOfDigfits = int.Parse(Console.ReadLine());

            var array = new int[numbersOfDigfits];

            for (int i = 0; i < numbersOfDigfits; i++)
            {
                var digit = int.Parse(Console.ReadLine());

                array[i] = digit;
            }

            var minDigit = array.Min();
            var maxDigit = array.Max();

            Console.WriteLine($"Max number: {maxDigit}");
            Console.WriteLine($"Min number: {minDigit}");
        }
    }
}
