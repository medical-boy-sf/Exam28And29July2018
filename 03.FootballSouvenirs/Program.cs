using System;

namespace _03.FootballSouvenirs
{
    class Program
    {
        static void Main()
        {
            string team = Console.ReadLine();
            string typeSouvenir = Console.ReadLine();
            int numberSouvenirs = int.Parse(Console.ReadLine());
            double price = 0;

            if (team == "Argentina")
            {
                if (typeSouvenir == "flags")
                {
                    price = 3.25;
                }

                else if (typeSouvenir == "caps")
                {
                    price = 7.2;
                }

                else if (typeSouvenir == "posters")
                {
                    price = 5.10;
                }

                else if (typeSouvenir == "stickers")
                {
                    price = 1.25;
                }

                else
                {
                    Console.WriteLine($"Invalid stock!");
                    return;
                }
            }

            else if (team == "Brazil")
            {
                if (typeSouvenir == "flags")
                {
                    price = 4.2;
                }

                else if (typeSouvenir == "caps")
                {
                    price = 8.5;
                }

                else if (typeSouvenir == "posters")
                {
                    price = 5.35;
                }

                else if (typeSouvenir == "stickers")
                {
                    price = 1.2;
                }

                else
                {
                    Console.WriteLine($"Invalid stock!");
                    return;
                }
            }

            else if (team == "Croatia")
            {
                if (typeSouvenir == "flags")
                {
                    price = 2.75;
                }

                else if (typeSouvenir == "caps")
                {
                    price = 6.9;
                }

                else if (typeSouvenir == "posters")
                {
                    price = 4.95;
                }

                else if (typeSouvenir == "stickers")
                {
                    price = 1.10;
                }

                else
                {
                    Console.WriteLine($"Invalid stock!");
                    return;
                }
            }

            else if (team == "Denmark")
            {
                if (typeSouvenir == "flags")
                {
                    price = 3.10;
                }

                else if (typeSouvenir == "caps")
                {
                    price = 6.5;
                }

                else if (typeSouvenir == "posters")
                {
                    price = 4.8;
                }

                else if (typeSouvenir == "stickers")
                {
                    price = 0.9;
                }

                else
                {
                    Console.WriteLine($"Invalid stock!");
                    return;
                }
            }

            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            double sum = price * numberSouvenirs;

            Console.WriteLine($"Pepi bought {numberSouvenirs} {typeSouvenir} of {team} for {sum:F2} lv.");
        }
    }
}
