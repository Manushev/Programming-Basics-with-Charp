using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var availableMoney = 0.0;
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "NoMoreMoney")
                {
                    break;
                }

                var paymant = double.Parse(cmd);

                if (paymant < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {paymant:F2}");
                    availableMoney += paymant;
                }
            }

            Console.WriteLine($"Total: {availableMoney:F2}");
        }
    }
}
