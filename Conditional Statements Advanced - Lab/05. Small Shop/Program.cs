using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        const string SofiaCity = "Sofia";
        const string PlovdivCity = "Plovdiv";
        const string VarnaCity = "Varna";
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            double sum = 0;

            switch (city)
            {
                case SofiaCity:
                    if (product is "coffee")
                    {
                        sum = quantity * 0.50;
                    }
                    else if (product is "water")
                    {
                        sum = quantity * 0.80;
                    }
                    else if (product is "beer")
                    {
                        sum = quantity * 1.20;
                    }
                    else if (product is "sweets")
                    {
                        sum = quantity * 1.45;
                    }
                    else if (product is "peanuts")
                    {
                        sum = quantity * 1.60;
                    }
                    break;
                    case PlovdivCity:
                    if (product is "coffee")
                    {
                        sum = quantity * 0.40;
                    }
                    else if (product is "water")
                    {
                        sum = quantity * 0.70;
                    }
                    else if (product is "beer")
                    {
                        sum = quantity * 1.15;
                    }
                    else if (product is "sweets")
                    {
                        sum = quantity * 1.30;
                    }
                    else if (product is "peanuts")
                    {
                        sum = quantity * 1.50;
                    }
                    break;
                    case VarnaCity:
                    if (product is "coffee")
                    {
                        sum = quantity * 0.45;
                    }
                    else if (product is "water")
                    {
                        sum = quantity * 0.70;
                    }
                    else if (product is "beer")
                    {
                        sum = quantity * 1.10;
                    }
                    else if (product is "sweets")
                    {
                        sum = quantity * 1.35;
                    }
                    else if (product is "peanuts")
                    {
                        sum = quantity * 1.55;
                    }
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}
