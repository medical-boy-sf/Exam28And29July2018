using System;

namespace _02.FootballKit
{
    class Program
    {
        static void Main()
        {
            double priceTShirt = double.Parse(Console.ReadLine());
            double sumNeededForBall = double.Parse(Console.ReadLine());

            double priceShorts = 0.75 * priceTShirt;
            double priceSocks = 0.2 * priceShorts;
            double priceButtons = 2 * (priceTShirt + priceShorts);
            double totalSum = priceTShirt + priceShorts + priceSocks + priceButtons;
            totalSum = totalSum - totalSum * 0.15;

            if (totalSum >= sumNeededForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSum:F2} lv.");
            }

            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumNeededForBall - totalSum):F2} lv. more.");
            }
        }
    }
}
