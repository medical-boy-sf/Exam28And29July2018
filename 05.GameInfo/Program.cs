using System;

namespace _05.GameInfo
{
    class Program
    {
        static void Main()
        {
            string nameTeam = Console.ReadLine();
            int numberGames = int.Parse(Console.ReadLine());
            int totalTime = 0;

            for (int i = 0; i < numberGames; i++)
            {
                int timeGame = int.Parse(Console.ReadLine());
                totalTime += timeGame;
            }

            Console.WriteLine($"{nameTeam} has played {totalTime} minutes. Average minutes per game: {((double)totalTime / numberGames):F2}");
        }
    }
}
