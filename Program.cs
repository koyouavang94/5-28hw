using System;

namespace hwReview528
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend");
            Console.WriteLine("Choose your favorite anime:");
            Console.WriteLine("1. Naruto, 2. One Punch Man, 3. Black Clover");
            string weapon = Console.ReadLine();

            switch (weapon)
            {
                case "1":
                    Naruto();
                    break;
                case "2":
                    OnePunchMan(1);
                    break;
                case "3":
                    string result = BlackClover(2);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Do you even watch anime?");
                    break;
            }
        }

        private static void Naruto()
        {
            Console.WriteLine("You chose Naruto! Dattebayo!");
        }

        private static void OnePunchMan(int number)
        {
            Console.WriteLine("You chose One Punch Man");
            Console.WriteLine("He only needs {0} punch to win his fights!", number);
        }

        private static string BlackClover(int looper)
        {
            Console.WriteLine("You chose Black Clover");
            for (int i = 0; i < looper; i++)
            {
                BlackClover(i);
            }

            return "How often have you rewatched this? They need more episodes, don't they?";
        }
    }
}