using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var degrees = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();

            var outFit = string.Empty;
            var shoes = string.Empty;

            if (10 <= degrees && degrees <=18)
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else
            {
                if (timeOfDay == "Morning")
                {
                    outFit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outFit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outFit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outFit} and {shoes}.");
        }
    }
}
