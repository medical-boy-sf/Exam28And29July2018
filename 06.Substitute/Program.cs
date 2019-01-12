using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main()
        {
            int firstFirstNumber = int.Parse(Console.ReadLine());
            int firstSecondNumber = int.Parse(Console.ReadLine());

            int secondFirstNumber = int.Parse(Console.ReadLine());
            int secondSecondNUmber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstNumber = firstFirstNumber; firstNumber <= 8; firstNumber++)
            {
                for (int secondNumber = 9; secondNumber >= firstSecondNumber; secondNumber--)
                {
                    for (int thirdNumber = secondFirstNumber; thirdNumber <= 8; thirdNumber++)
                    {
                        for (int fourthNumber = 9; fourthNumber >= secondSecondNUmber; fourthNumber--)
                        {

                            if (firstNumber % 2 == 0 && secondNumber % 2 == 1 && thirdNumber % 2 == 0 && fourthNumber % 2 == 1)
                            {

                                if (firstNumber == thirdNumber &&
                                       secondNumber == fourthNumber)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine("{0}{1} - {2}{3}",
                                        firstNumber,
                                        secondNumber,
                                        thirdNumber,
                                        fourthNumber);
                                    counter++;
                                }

                                if (counter == 6)
                                {
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
