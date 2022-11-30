using System;

namespace _04._Password_Guess
{
    internal class Program
    {
        const string Password = "s3cr3t!P@ssw0rd";
        static void Main(string[] args)
        {
            var passwordGuess = Console.ReadLine();

            if (passwordGuess == Password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
