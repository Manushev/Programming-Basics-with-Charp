using System;

namespace _07._Shopping
{
    internal class Program
    {
        const double PricePerVideoCard = 250;
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var videoCards = int.Parse(Console.ReadLine());
            var processors = int.Parse(Console.ReadLine());
            var ramMemory = int.Parse(Console.ReadLine());

            var sumPerVideoCards = videoCards * PricePerVideoCard;
            var sumPerProcessors = processors * (sumPerVideoCards * 0.35);
            var sumPerRamMemory = ramMemory * (sumPerVideoCards * 0.10);

            var totalSum = sumPerVideoCards + sumPerProcessors + sumPerRamMemory;

            //Ако броя на видеокартите е по-голям от този на процесорите получава 15% отстъпка от крайната сметка
            if (videoCards > processors)
            {
                totalSum -= totalSum * 0.15;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:F2} leva more!");
            }
        }
    }
}
