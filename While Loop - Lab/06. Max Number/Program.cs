using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maxNumber = int.MinValue;

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "Stop")
                {
                    break;
                }

                var number = int.Parse(cmd);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
