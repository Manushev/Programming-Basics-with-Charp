using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filmName = Console.ReadLine();
            var episode = int.Parse(Console.ReadLine());
            var breakTime = int.Parse(Console.ReadLine());
            
            double lunch = breakTime * 0.125;
            double rest = breakTime * 0.25;
            double timeForRest = episode + lunch + rest;
            if (timeForRest <= breakTime)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(breakTime - timeForRest)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Ceiling(timeForRest - breakTime)} more minutes.");
            }
        }
    }
}
