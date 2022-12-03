using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        const string Square = "square";
        const string Rectangle = "rectangle";
        const string Circle = "circle";
        const string Triangle = "triangle";
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            double area = 0;
            
            if (figure is Square)
            {
                var length = double.Parse(Console.ReadLine());
                area = length * length;
            }
            else if (figure is Rectangle)
            {
                var lengthA = double.Parse(Console.ReadLine());
                var lengthB = double.Parse(Console.ReadLine());
                area = lengthA * lengthB;
            }
            else if (figure is Circle)
            {
                var radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure is Triangle)
            {
                var length = double.Parse((Console.ReadLine()));
                var height = double.Parse((Console.ReadLine()));
                area = (length * height) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
