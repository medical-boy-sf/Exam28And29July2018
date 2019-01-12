using System;

namespace _02.BeerAndChips
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberBeers = int.Parse(Console.ReadLine());
            int numberPacketsChips = int.Parse(Console.ReadLine());

            double sumBeers = numberBeers * 1.2;
            double pricePacketsChips = sumBeers * 0.45;
            double sumPacketsChips = Math.Ceiling(pricePacketsChips * numberPacketsChips);
            double totalSum = sumBeers + sumPacketsChips;

            if (budget >= totalSum)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - totalSum):F2} leva left.");
            }

            else
            {
                Console.WriteLine($"{name} needs {(totalSum - budget):F2} more leva!");
            }
        }
    }
}
