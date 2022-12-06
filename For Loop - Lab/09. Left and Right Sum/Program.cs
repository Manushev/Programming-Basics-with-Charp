using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfDigits = int.Parse(Console.ReadLine());

            var leftSum = 0;
            var rightSum = 0;

            for (int i = 1; i <= numberOfDigits * 2; i++)
            {
                var digit = int.Parse(Console.ReadLine());

                if (i <= numberOfDigits)
                {
                    leftSum += digit;
                }
                else
                {
                    rightSum += digit;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {leftSum - rightSum}");
            }
        }
    }
}
