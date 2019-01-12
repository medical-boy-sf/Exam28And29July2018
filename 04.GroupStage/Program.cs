using System;

namespace _04.GroupStage
{
    class Program
    {
        static void Main()
        {
            string nameTeam = Console.ReadLine();
            int points = 0;
            int difference = 0;
            int counter = 0;
            int numberOfGames = int.Parse(Console.ReadLine());
            int goalsGiven = 0;
            int goalsReceived = 0;
            int sumGoalsGiven = 0;
            int sumGoalsReceived = 0;

            while (true)
            {
                if (counter >= numberOfGames)
                {
                    break;
                }

                goalsGiven = int.Parse(Console.ReadLine());
                goalsReceived = int.Parse(Console.ReadLine());
                sumGoalsGiven += goalsGiven;
                sumGoalsReceived += goalsReceived;

                if (goalsGiven > goalsReceived)
                {
                    points += 3;
                    difference += (goalsGiven - goalsReceived);
                }

                else if (goalsGiven == goalsReceived)
                {
                    points += 1;
                    difference += (goalsGiven - goalsReceived);
                }

                else
                {
                    difference += (goalsGiven - goalsReceived);
                }

                counter += 1;
            }

            if (sumGoalsReceived > sumGoalsGiven)
            {
                Console.WriteLine($"{nameTeam} has been eliminated from the group phase.");
            }

            else
            {
                Console.WriteLine($"{nameTeam} has finished the group phase with {points} points.");
            }
            Console.WriteLine($"Goal difference: {difference}.");
        }
    }
}
