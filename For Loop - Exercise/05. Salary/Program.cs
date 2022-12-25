using System;

namespace _05._Salary
{
    internal class Program
    {
        const int FacebookFine = 150;
        const int Instagramfine = 100;
        const int RedditFine = 50;
        static void Main(string[] args)
        {
            var numOfOpenTabs = int.Parse(Console.ReadLine());
            var salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numOfOpenTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

                var nameOfWebSite = Console.ReadLine();
                                
                if (nameOfWebSite == "Facebook")
                {
                    salary -= FacebookFine;
                }
                else if (nameOfWebSite == "Instagram")
                {
                    salary -= Instagramfine;
                }
                else if (nameOfWebSite == "Reddit")
                {
                    salary -= RedditFine;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            
        }
    }
}
