using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class RPSApp
    {
        public static void Title()
        {
            Console.Title = "Lab 13 - Rock, Paper, Scissors";
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
        }

        public static HumanPlayer CreateHumanPlayer()
        {
            HumanPlayer humanPlayer = new HumanPlayer();
            
            return humanPlayer;
        }

        public static Player ChooseOpponent(RockPlayer rockPlayer, RandomPlayer randomPlayer)
        {
            bool oppenentIsValid = false;
            do // Loops while the user chooses either the rock player or the random player as an opponent
            {
                Console.Write($"Would you like to play against {rockPlayer.Name} or {randomPlayer.Name} ({rockPlayer.Name[4].ToString().ToLower()}/{randomPlayer.Name[4].ToString().ToLower()})? ");
                string opponent = Console.ReadLine();
                if (opponent.ToLower().Trim() == rockPlayer.Name[4].ToString().ToLower())
                {
                    oppenentIsValid = true;
                    return rockPlayer;
                }
                else if (opponent.ToLower().Trim() == randomPlayer.Name[4].ToString().ToLower())
                {
                    oppenentIsValid = true;
                    return randomPlayer;
                }
                else
                {
                    oppenentIsValid = false;
                    HelperMethods.ErrorMessage("Please choose a valid opponent.");
                }
            } while (oppenentIsValid == false);
            return new HumanPlayer();
        }

        public static string WinningConditions(RPS playersRPSChoice, RPS oppenentsChoice, HumanPlayer player1, Player opponent)
        {
            string message = "";
            if ((playersRPSChoice == RPS.rock && oppenentsChoice == RPS.rock) || (playersRPSChoice == RPS.paper && oppenentsChoice == RPS.paper) || (playersRPSChoice == RPS.scissors && oppenentsChoice == RPS.scissors))
            {
                message = "Draw!";
            }
            else if ((playersRPSChoice == RPS.paper && oppenentsChoice == RPS.rock) || (playersRPSChoice == RPS.rock && oppenentsChoice == RPS.scissors) || (playersRPSChoice == RPS.scissors && oppenentsChoice == RPS.paper))
            {
                message = $"{player1.Name} wins!";
                player1.NumberOfWins++;
            }
            else
            {
                message = $"{opponent.Name} win!";
                opponent.NumberOfWins++;
            }

            return message;
        }

        public static void PlayGame()
        {
            Title();

            Welcome();

            RockPlayer rockPlayer = new RockPlayer();
            rockPlayer.Name = "The Rocks";
            rockPlayer.NumberOfWins = 0;
            RandomPlayer randomPlayer = new RandomPlayer();
            randomPlayer.Name = "The Sharks";
            randomPlayer.NumberOfWins = 0;

            HumanPlayer player1 = CreateHumanPlayer();
            player1.Name = HumanPlayer.GetusersName();
            player1.NumberOfWins = 0;
            Console.WriteLine();

            Player opponent = ChooseOpponent(rockPlayer, randomPlayer);
            Console.WriteLine();

            bool playAgain = false;
            do
            {
                RPS playersRPSChoice = player1.GenerateRPS();
                RPS oppenentsChoice = opponent.GenerateRPS();

                // Game summary
                Console.WriteLine();
                Console.WriteLine($"{player1.Name}: {playersRPSChoice}");
                Console.WriteLine($"{opponent.Name}: {oppenentsChoice}");
                Console.WriteLine(WinningConditions(playersRPSChoice, oppenentsChoice, player1, opponent));
                Console.WriteLine();
                Console.WriteLine("==========");
                Console.WriteLine($"{player1.Name}'s total wins: {player1.NumberOfWins}");
                Console.WriteLine($"{opponent.Name}'s total wins: {opponent.NumberOfWins}");
                Console.WriteLine();

                Console.Write("Play again? (y/n): ");
                string userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput.ToLower().Trim())
                {
                    case "y":
                        playAgain = true;
                        break;
                    case "n":
                        playAgain = false;
                        break;
                    default:
                        HelperMethods.ErrorMessage("Please enter either 'y' or 'n'.");
                        break;
                }

            } while (playAgain == true);

            Exit();            
        }

        public static void Exit()
        {
            Console.WriteLine("Thank you for playing. Goodbye!");
            Console.ReadKey();
        }

    }
}
