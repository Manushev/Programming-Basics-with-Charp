using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine();

            Console.WriteLine();

            while (cmd != "Stop")
            {
                Console.WriteLine(cmd);
                cmd = Console.ReadLine();

            }
        }
    }
}
