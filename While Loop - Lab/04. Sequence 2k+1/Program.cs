using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = 1;

            while (k <= n)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
