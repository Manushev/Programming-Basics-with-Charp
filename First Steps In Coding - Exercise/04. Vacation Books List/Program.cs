using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfPages = int.Parse(Console.ReadLine());
            var readedPages = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());

            var readTime = numberOfPages / readedPages;
            var timePeDay = readTime / days;

            Console.WriteLine(timePeDay);
        }
    }
}
