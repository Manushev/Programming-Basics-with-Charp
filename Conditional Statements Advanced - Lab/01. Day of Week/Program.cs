using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numOfDay = int.Parse(Console.ReadLine());

            var nameOfDay = string.Empty;

            switch (numOfDay)
            {
                case 1:
                    nameOfDay = "Monday";
                    break;
                case 2:
                    nameOfDay = "Tuesday";
                    break;
                case 3:
                    nameOfDay = "Wednesday";
                    break;
                case 4:
                    nameOfDay = "Thursday";
                    break;
                case 5:
                    nameOfDay = "Friday";
                    break;
                case 6:
                    nameOfDay = "Saturday";
                    break;
                case 7:
                    nameOfDay = "Sunday";
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine(nameOfDay);
        }
    }
}
