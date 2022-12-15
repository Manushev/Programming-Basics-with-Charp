using System;

namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var output = string.Empty;

            if (number != 0 && number >= -100 && number <= 100)
            {
                output = "Yes";
            }
            else
            {
                output = "No";
            }

            Console.WriteLine(output);
        }
    }
}
