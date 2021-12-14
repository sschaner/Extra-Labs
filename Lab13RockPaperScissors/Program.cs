using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            Welcome();

            RockPlayer rockPlayer = new RockPlayer();
            rockPlayer.Name = "The Jets";
            RandomPlayer randomPlayer = new RandomPlayer();
            randomPlayer.Name = "The Sharks";
            HumanPlayer player1 = RPSApp.CreateHumanPlayer();
            player1.Name = HumanPlayer.GetusersName();

            RPSApp.GameSummary(player1, rockPlayer, randomPlayer);

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

        public static void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
