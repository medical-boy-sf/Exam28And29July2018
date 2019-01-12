using System;

namespace _05.FanShop
{
    class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            int numberSubjects = int.Parse(Console.ReadLine());
            double price = 0;
            double expenses = 0;

            for (int i = 0; i < numberSubjects; i++)
            {
                string subject = Console.ReadLine().ToLower();

                switch (subject)
                {
                    case "hoodie":
                        price = 30;
                        break;
                    case "keychain":
                        price = 4;
                        break;
                    case "t-shirt":
                        price = 20;
                        break;
                    case "flag":
                        price = 15;
                        break;
                    case "sticker":
                        price = 1;
                        break;
                    default:
                        break;
                }

                expenses += price;
            }

            if (budget >= expenses)
            {
                Console.WriteLine($"You bought {numberSubjects} items and left with {budget - expenses} lv.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {expenses - budget} more lv.");
            }
        }
    }
}
