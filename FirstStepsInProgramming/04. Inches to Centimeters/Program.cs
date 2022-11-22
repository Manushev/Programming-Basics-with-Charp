using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        const double centimetersPerInch = 2.54;
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());

            var centimeters = inches * centimetersPerInch;

            Console.WriteLine(centimeters);
        }
    }
}
