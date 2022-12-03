using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
            {
                minutes += 15;

                if (minutes > 59)
                {
                    hour += 1;
                    minutes -= 60;
                }
                if (hour > 23)
                {
                    hour = 0;
                }
                if (minutes < 10)
                {
                    Console.WriteLine($"{hour}:0{minutes}");
                    return;
                }

                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
