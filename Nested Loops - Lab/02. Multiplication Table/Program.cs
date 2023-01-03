using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int f = 1; f <= 10; f++)
                {
                    Console.WriteLine($"{i} * {f} = {i * f}");
                }
            }
        }
    }
}
