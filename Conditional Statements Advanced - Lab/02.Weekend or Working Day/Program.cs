using System;

namespace _02.Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dayOfWeek = Console.ReadLine();

            var workingOrWeekendDay = string.Empty;

            switch (dayOfWeek)
            {
                case "Monday":
                    workingOrWeekendDay = "Working day";
                    break;
                case "Tuesday":
                    workingOrWeekendDay = "Working day";
                    break;
                case "Wednesday":
                    workingOrWeekendDay = "Working day";
                    break;
                case "Thursday":
                    workingOrWeekendDay = "Working day";
                    break;
                case "Friday":
                    workingOrWeekendDay = "Working day";
                    break;
                case "Saturday":
                    workingOrWeekendDay = "Weekend";
                    break;
                case "Sunday":
                    workingOrWeekendDay = "Weekend";
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine(workingOrWeekendDay);
        }
    }
}
