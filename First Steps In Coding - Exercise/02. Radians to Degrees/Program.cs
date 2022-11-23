using System;

namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());

            var degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
