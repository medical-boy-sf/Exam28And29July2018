using System;
namespace _01.Stadium_Income
{
    class Program
    {
        static void Main()
        {
            int numberOfSectors = int.Parse(Console.ReadLine());
            int capacityStadium = int.Parse(Console.ReadLine());
            double pricePerTicket = double.Parse(Console.ReadLine());

            double incomePerSector = (capacityStadium * pricePerTicket) / numberOfSectors;
            double totalSum = capacityStadium * pricePerTicket;

            double moneyForCharity = (totalSum - (incomePerSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalSum:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");
        }
    }
}
