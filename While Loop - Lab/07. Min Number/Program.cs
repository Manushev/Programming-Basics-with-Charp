using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minNumber = int.MaxValue;

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Stop")
                {
                    break;
                }

                var number = int.Parse(cmd);

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
