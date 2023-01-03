using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numOfUnsatisfactoryGrades = int.Parse(Console.ReadLine());

            var numberOfProblems = 0;
            var unsatisfactoryGrades = 0;
            var sumOfGrade = 0.0;
            var lastTask = string.Empty;

            while (unsatisfactoryGrades != numOfUnsatisfactoryGrades)
            {
                var task = Console.ReadLine();
                if (task == "Enough")
                {
                    break;
                }

                var grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    unsatisfactoryGrades++;
                }

                

                numberOfProblems++;
                sumOfGrade += grade;
                lastTask = task;
            }

            if (unsatisfactoryGrades == numOfUnsatisfactoryGrades)
            {
                Console.WriteLine($"You need a break, {numOfUnsatisfactoryGrades} poor grades.");
                return;
            }

            Console.WriteLine($"Average score: {sumOfGrade / numberOfProblems:F2}");
            Console.WriteLine($"Number of problems: {numberOfProblems}");
            Console.WriteLine($"Last problem: {lastTask}");
        }
    }
}
