using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lilysAge = int.Parse(Console.ReadLine());
            var priceOfWashingMachine = double.Parse(Console.ReadLine());
            var pricePerToy = int.Parse(Console.ReadLine());

            var pricePerBirthday = 10;
            var saveMoney = 0.0;
            var toy = 0;

            for (int i = 1; i <= lilysAge; i++)
            {
                if (i % 2 == 0)
                {
                    saveMoney += pricePerBirthday;
                    //one lev for her Brother from every birthday
                    saveMoney--;
                    pricePerBirthday += 10;

                }
                else
                {
                    toy++;
                }
            }

            var moneyFromToy = toy * pricePerToy;
            saveMoney += moneyFromToy;

            if (saveMoney >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {saveMoney - priceOfWashingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(saveMoney - priceOfWashingMachine):F2}");
            }
        }
    }
}
