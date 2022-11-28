using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var percentage = double.Parse(Console.ReadLine()) * 1 / 100;

            var volumeTank = length * width * height;
            var volumeLiters = volumeTank * 0.001;
            var litersNeeded = volumeLiters * (1 - percentage);

            Console.WriteLine(litersNeeded);
        }
    }
}
