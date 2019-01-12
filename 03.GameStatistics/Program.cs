using System;

namespace _03.GameStatistics
{
    class Program
    {
        static void Main()
        {
            int minutes = int.Parse(Console.ReadLine());
            string nameOfThePlayer = Console.ReadLine();

            if (minutes >= 45)
            {
                Console.WriteLine("Second half time.");
                if (minutes > 80 && minutes <= 90)
                {
                    Console.WriteLine($"{nameOfThePlayer} SCORED A GOAL FROM PENALTY !!!");
                }
                else if (minutes > 55)
                {
                    Console.WriteLine($"{nameOfThePlayer} missed a shot from corner.");
                    if (minutes % 2 == 1)
                    {
                        Console.WriteLine($"{nameOfThePlayer} has been changed with another player.");
                    }
                }
                else if (minutes > 45)
                {
                    Console.WriteLine($"{nameOfThePlayer} got a freekick.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{nameOfThePlayer} missed the freekick.");
                    }
                }
            }
            else if (minutes > 0)
            {
                Console.WriteLine("First half time.");
                if (minutes > 35)
                {
                    Console.WriteLine($"{nameOfThePlayer} SCORED A GOAL !!!");
                }

                else if (minutes > 10)
                {
                    Console.WriteLine($"{nameOfThePlayer} received yellow card.");
                    if (minutes % 2 == 1)
                    {
                        Console.WriteLine($"{nameOfThePlayer} got another yellow card.");
                    }
                }
                else if (minutes > 1)
                {
                    Console.WriteLine($"{nameOfThePlayer} missed a penalty.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{nameOfThePlayer} was injured after the penalty.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Match has just began!");
            }
        }
    }
}
