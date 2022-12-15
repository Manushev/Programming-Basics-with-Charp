using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            var output = string.Empty;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hour >= 10 && hour <= 18)
                    {
                        output = "open";
                    }
                    else
                    {
                        output = "closed";
                    }
                    break;
                case "Sunday":
                    output = "closed";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
