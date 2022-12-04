using System;

namespace _06._Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var recordInSeconds = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var timeInSeconds = double.Parse(Console.ReadLine());

            var seconds = distance * timeInSeconds;
            
            var delayTimesInSeconds = Math.Floor(distance / 15) * 12.5;

            var totalTime = seconds + delayTimesInSeconds;

            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
