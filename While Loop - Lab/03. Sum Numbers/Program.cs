using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            while (true)
            {
                var currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

                if (sum >= num)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
