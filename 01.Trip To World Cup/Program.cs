using System;

namespace _01.Trip_To_World_Cup
{
    class Program
    {
        static void Main()
        {
            double priceGo = double.Parse(Console.ReadLine());
            double priceReturn = double.Parse(Console.ReadLine());
            double priceTicketGame = double.Parse(Console.ReadLine());
            int numberGames = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine()) * 0.01;

            double sumTickets = 6 * (priceGo + priceReturn);
            sumTickets = sumTickets - sumTickets * discount;
            double sumGames = 6 * numberGames * priceTicketGame;
            double totalSum = sumTickets + sumGames;
            double sumToPerson = totalSum / 6;

            Console.WriteLine($"Total sum: {totalSum:F2} lv.");
            Console.WriteLine($"Each friend has to pay {sumToPerson:F2} lv.");
        }
    }
}
