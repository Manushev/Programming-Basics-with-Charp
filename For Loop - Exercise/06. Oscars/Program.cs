using System;

namespace _06._Oscars
{
    internal class Program
    {
        const double NominationPoints = 1250.5;
        static void Main(string[] args)
        {
            var actorName = Console.ReadLine();
            var pointsFromAcademy = double.Parse(Console.ReadLine());
            var evaluatives = int.Parse(Console.ReadLine());

            var totalPoints = 0.0;

            for (int i = 0; i < evaluatives; i++)
            {
                var evaluativeName = Console.ReadLine();
                var points = double.Parse(Console.ReadLine());

                totalPoints = (evaluativeName.Length * points) / 2;
                                
                pointsFromAcademy += totalPoints;

                if (pointsFromAcademy >= NominationPoints)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:F1}!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(pointsFromAcademy - NominationPoints):F1} more!");
        }
    }
}
