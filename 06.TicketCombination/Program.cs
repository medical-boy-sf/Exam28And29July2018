using System;

namespace _06.TicketCombination
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 'B'; i <= 'L'; i += 2)
            {
                for (int j = 'f'; j >= 'a'; j--)
                {
                    for (int k = 'A'; k <= 'C'; k++)
                    {
                        for (int m = 1; m <= 10; m++)
                        {
                            for (int n = 10; n >= 1; n--)
                            {
                                counter += 1;
                                if (counter == num)
                                {
                                    Console.WriteLine($"Ticket combination: {(char)i}{(char)j}{(char)k}{m}{n}");
                                    sum = i + j + k + m + n;
                                    Console.WriteLine($"Prize: {sum} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
