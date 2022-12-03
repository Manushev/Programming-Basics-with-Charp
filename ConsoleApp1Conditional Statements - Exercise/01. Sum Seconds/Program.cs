using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            var totalTimeInSeconds = firstTime + secondTime + thirdTime;
            
            var minutes = totalTimeInSeconds / 60;
            var seconds = totalTimeInSeconds % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
                return;
            }
            Console.WriteLine($"{minutes}:{seconds}");
            
        }
    }
}
