using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var classCounter = 0;
            var brokenClass = 0;
            var averageEvaluation = 0.0;

            while (classCounter != 12)
            {
                var evaluation = double.Parse(Console.ReadLine());

                if (evaluation < 4.00)
                {
                    brokenClass++;
                    if (brokenClass == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {classCounter} grade");
                        return;
                    }
                }

                classCounter++;
                averageEvaluation += evaluation;

            }
            Console.WriteLine($"{studentName} graduated. Average grade: {averageEvaluation / classCounter:F2}");
        }
    }
}
