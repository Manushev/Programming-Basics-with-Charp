using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
                        
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number <= 200)
                {
                    p1++;
                }
                else if (number <= 399)
                {
                    p2++;
                }
                else if (number <= 599)
                {
                    p3++;
                }
                else if (number <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 / n * 100:F2}%");
            Console.WriteLine($"{p2 / n * 100:F2}%");
            Console.WriteLine($"{p3 / n * 100:F2}%");
            Console.WriteLine($"{p4 / n * 100:F2}%");
            Console.WriteLine($"{p5 / n * 100:F2}%");
        }
    }
}
