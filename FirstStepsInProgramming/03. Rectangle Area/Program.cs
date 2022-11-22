using System;

namespace _03._Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var rectangleArea = a * b;

            Console.WriteLine(rectangleArea);
        }
    }
}
