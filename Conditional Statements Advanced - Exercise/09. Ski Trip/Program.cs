using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        const double RoomPerNight = 18;
        const double ApartmentPerNight = 25;
        const double PresidentApartmentPerNight = 35;
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var typeOfRoom = Console.ReadLine();
            var assessment = Console.ReadLine();

            var nights = days - 1;
            var totalPrice = 0.0;
            var discount = 0.0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    totalPrice = nights * RoomPerNight;
                    break;
                case "apartment":
                    totalPrice = nights * ApartmentPerNight;

                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    totalPrice = nights * PresidentApartmentPerNight;

                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.20;
                    }
                    break;
            }

            totalPrice -= totalPrice * discount;

            if (assessment is "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (assessment is "negative")
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
