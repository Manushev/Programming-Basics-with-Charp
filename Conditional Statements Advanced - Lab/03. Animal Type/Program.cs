using System;

namespace _03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameOfAnimal = Console.ReadLine();

            var typeOfAnimal = string.Empty;

            switch (nameOfAnimal)
            {
                case "dog":
                    typeOfAnimal = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    typeOfAnimal = "reptile";
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }

            Console.WriteLine(typeOfAnimal);
        }
    }
}
