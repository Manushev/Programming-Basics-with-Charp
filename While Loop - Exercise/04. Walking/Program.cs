using System;

namespace _04._Walking
{
    internal class Program
    {
        const int PurposeStepPerDay = 10000;
        static void Main(string[] args)
        {

            var currentSteps = 0;
            var isGoingHome = false;

            while (currentSteps <= PurposeStepPerDay && !isGoingHome)
            {
                var cmd = Console.ReadLine();

                if (cmd == "Going home")
                {
                    cmd = Console.ReadLine();
                    isGoingHome = true;
                }

                var steps = int.Parse(cmd);

                currentSteps += steps;
            }

            if (currentSteps >= PurposeStepPerDay)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(PurposeStepPerDay - currentSteps)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(PurposeStepPerDay - currentSteps)} more steps to reach goal.");
            }
        }
    }
}
