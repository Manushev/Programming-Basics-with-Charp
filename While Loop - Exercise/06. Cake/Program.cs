using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var widthCake = int.Parse(Console.ReadLine());
            var lengthCake = int.Parse(Console.ReadLine());

            var pieceOfCake = widthCake * lengthCake;

            while (pieceOfCake >= 0)
            {
                var cmd = Console.ReadLine();
                if (cmd == "STOP")
                {
                    Console.WriteLine($"{pieceOfCake} pieces are left.");
                    break;
                }

                var pieces = int.Parse(cmd);

                pieceOfCake -= pieces;
            }

            if (pieceOfCake <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieceOfCake)} pieces more.");
            }
        }
    }
}
