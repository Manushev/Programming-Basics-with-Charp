using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        const int hourPerProject = 3;
        static void Main(string[] args)
        {
            var nameOfArchitect = Console.ReadLine();
            var numOfProjects = int.Parse(Console.ReadLine());

            var needHours = numOfProjects * hourPerProject;

            Console.WriteLine($"The architect {nameOfArchitect} will need {needHours} hours to complete {numOfProjects} project/s.");
        }
    }
}
