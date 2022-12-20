using System;

namespace _06.Between_Numbers
{
    internal class Program
    {
        const string Gathering = "+";
        const string Removal = "-";
        const string Multiplication = "*";
        const string Division = "/";
        const string ModularDivision = "%";
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            var result = 0.0; 
            var oddOrEvenResult = string.Empty;

            if (symbol == Gathering)
            {
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                {
                    oddOrEvenResult = "even";
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {oddOrEvenResult}");
                }
                else
                {
                    oddOrEvenResult = "odd";
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {oddOrEvenResult}");
                }
            }
            else if (symbol == Removal)
            {
                result = firstNumber - secondNumber;
                if (result % 2 == 0)
                {
                    oddOrEvenResult = "even";
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {oddOrEvenResult}");
                }
                else
                {
                    oddOrEvenResult = "odd";
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {oddOrEvenResult}");
                }
            }
            else if (symbol == Multiplication)
            {
                result = firstNumber * secondNumber;
                if (result % 2 == 0)
                {
                    oddOrEvenResult = "even";
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {oddOrEvenResult}");
                }
                else
                {
                    oddOrEvenResult = "odd";
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {oddOrEvenResult}");
                }
            }
            else if(symbol == Division)
            {
                if (secondNumber != 0)
                {
                    result = (firstNumber * 1.0) / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
            }
            else if (symbol == ModularDivision)
            {
                if (secondNumber != 0)
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
            }           
        }
    }
}
