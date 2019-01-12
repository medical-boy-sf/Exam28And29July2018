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
            int cont = 0;
            int dus = 0;

            for (int i = 0; i < numberGames; i++)
            {
                int timeGame = int.Parse(Console.ReadLine());
                totalTime += timeGame;

                if (timeGame > 120)
                {
                    dus += 1;
                }

                else if (timeGame > 90)
                {
                    cont += 1;
                }
            }

            Console.WriteLine($"{nameTeam} has played {totalTime} minutes. Average minutes per game: {((double)totalTime / numberGames):F2}");
            Console.WriteLine($"Games with penalties: {dus}");
            Console.WriteLine($"Games with additional time: {cont}");
        }
    }
}
