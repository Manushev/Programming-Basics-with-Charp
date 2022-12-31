using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = Console.ReadLine();
            var searchBook = Console.ReadLine();
            var bookCounter = 0;
            
            while (searchBook != "No More Books")
            {
                if (searchBook == book)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }

                searchBook = Console.ReadLine();
                bookCounter++;
            }

            if (book != searchBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
