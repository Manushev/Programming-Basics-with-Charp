using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var widthOfSpace = int.Parse(Console.ReadLine());
            var lengthOfSpace = int.Parse(Console.ReadLine());
            var heightOfSpace = int.Parse(Console.ReadLine());

            var totalFreeSpace =  widthOfSpace * lengthOfSpace * heightOfSpace;

            while (totalFreeSpace > 0)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Done")
                {
                    break;
                }

                var numOfBox = int.Parse(cmd);
                totalFreeSpace -= numOfBox;
            }

            if (totalFreeSpace > 0)
            {
                Console.WriteLine($"{totalFreeSpace} Cubic meters left.");
            }
                
            if (totalFreeSpace <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace)} Cubic meters more.");
            }
        }
    }
}
