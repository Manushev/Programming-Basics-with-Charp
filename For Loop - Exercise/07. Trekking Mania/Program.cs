using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numOfGroups = int.Parse(Console.ReadLine());

            var climbingMusala = 0.0;
            var climbingMontBlanc = 0.0;
            var climbingKilimanjaro = 0.0;
            var climbingK2 = 0.0;
            var climbingEverest = 0.0;

            var totalNumOfPeople = 0;

            for (int i = 0; i < numOfGroups; i++)
            {
                var numOfPeople = int.Parse(Console.ReadLine());

                totalNumOfPeople += numOfPeople;

                if (numOfPeople <= 5)
                {
                    climbingMusala += numOfPeople;
                }
                else if (numOfPeople <= 12)
                {
                    climbingMontBlanc += numOfPeople;
                }
                else if (numOfPeople <= 25)
                {
                    climbingKilimanjaro += numOfPeople;
                }
                else if (numOfPeople <= 40)
                {
                    climbingK2 += numOfPeople;
                }
                else
                {
                    climbingEverest += numOfPeople;
                }
            }
            
            Console.WriteLine($"{climbingMusala / totalNumOfPeople * 100:F2}%");
            Console.WriteLine($"{climbingMontBlanc / totalNumOfPeople * 100:F2}%");
            Console.WriteLine($"{climbingKilimanjaro / totalNumOfPeople * 100:F2}%");
            Console.WriteLine($"{climbingK2 / totalNumOfPeople * 100:F2}%");
            Console.WriteLine($"{climbingEverest / totalNumOfPeople * 100:F2}%");
        }
    }
}
