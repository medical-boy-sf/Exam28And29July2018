using System;

namespace _04.BestPlayer
{
    class Program
    {
        static void Main()
        {
            string namePlayer = String.Empty;
            string goals = String.Empty;
            int goalsInt = 0;
            int maxNum = int.MinValue;
            string bestPlayer = String.Empty;

            while (true)
            {
                namePlayer = Console.ReadLine();
                if (namePlayer == "END") break;
                goals = Console.ReadLine().ToLower();
                goalsInt = int.Parse(goals);

                if (goalsInt > maxNum)
                {
                    maxNum = goalsInt;
                    bestPlayer = namePlayer;
                }

                if (goalsInt >= 10) break;
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (maxNum >= 3)
            {
                Console.WriteLine($"He has scored {maxNum} goals and made a hat-trick !!!");
            }

            else
            {
                Console.WriteLine($"He has scored {maxNum} goals.");
            }
        }
    }
}
