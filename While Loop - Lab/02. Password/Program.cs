using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();

            var currentPassword = Console.ReadLine();

            while (currentPassword != password)
            {
                currentPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
