using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        const int WPoints = 2000;
        const int FPoints = 1200;
        const int SFPoints = 720;
        static void Main(string[] args)
        {
            var numTournaments = int.Parse(Console.ReadLine());
            var startPoints = int.Parse(Console.ReadLine());

            var winPoints = 0;
            var numOfWinTournaments = 0;

            for (int i = 0; i < numTournaments; i++)
            {
                var stageOfTournament = Console.ReadLine();

                if (stageOfTournament == "W")
                {
                    winPoints += WPoints;
                    numOfWinTournaments++;
                }
                else if (stageOfTournament == "F")
                {
                    winPoints += FPoints;
                }
                else if (stageOfTournament == "SF")
                {
                    winPoints += SFPoints;
                }
            }
            ;
            var averageWinPoints = Math.Ceiling(winPoints / numTournaments * 1.0);
            var totalPoints = winPoints + startPoints;
            var percentageOfWinTournaments = (numOfWinTournaments * 1.0) / numTournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averageWinPoints}");
            Console.WriteLine($"{percentageOfWinTournaments:F2}%");
        }
    }
}
