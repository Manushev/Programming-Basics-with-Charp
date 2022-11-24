using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deposit = double.Parse(Console.ReadLine());
            var term = int.Parse(Console.ReadLine());
            var annualInterestRate = double.Parse(Console.ReadLine());

            //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            var total = deposit + term * ((deposit * (annualInterestRate / 100)) / 12);

            Console.WriteLine(total);
        }
    }
}
