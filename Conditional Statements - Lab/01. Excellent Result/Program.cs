using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var evaluation = double.Parse(Console.ReadLine());

            if (evaluation >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
