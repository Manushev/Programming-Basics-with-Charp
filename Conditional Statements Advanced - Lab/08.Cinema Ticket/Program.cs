using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();

            var tichetPrice = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    tichetPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    tichetPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    tichetPrice = 16;
                    break;
            }

            Console.WriteLine(tichetPrice);
        }
    }
}
