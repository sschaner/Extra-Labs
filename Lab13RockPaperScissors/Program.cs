using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            Welcome();
            string name = GetusersName();

            Exit();
        }

        public static void Title()
        {
            Console.Title = "Lab 13 - Rock, Paper, Scissors";
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
        }

        public static string GetusersName()
        {
            string name = "";
            Console.Write("Enter your name: ");
            return name = Console.ReadLine().Trim();
        }

        public static void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        
    }
}
