using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var neededMoneyForExcursion = double.Parse(Console.ReadLine());
            var availableMoney = double.Parse(Console.ReadLine());

            var consecutiveSpend = 0;
            var days = 0;

            while (consecutiveSpend != 5)
            {
                var action = Console.ReadLine();
                var money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    consecutiveSpend++;
                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    consecutiveSpend = 0;
                    availableMoney += money;
                }

                if (neededMoneyForExcursion <= availableMoney)
                {
                    break;
                }
            }

            if (consecutiveSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }

            if (availableMoney >= neededMoneyForExcursion)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
