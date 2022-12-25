using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());

            var sum = 0;
            var maxNumber = int.MinValue;

            for (int i = 0; i < numbers; i++)
            {
                var num = int.Parse((Console.ReadLine()));
                sum += num;

                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            var sumWithoutMaxNumber = sum - maxNumber;

            if (maxNumber == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sumWithoutMaxNumber)}");
            }
        }
    }
}
