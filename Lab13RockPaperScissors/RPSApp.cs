using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class RPSApp
    {
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter valid input.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (oppenentIsValid == false);
            return new HumanPlayer();
        }

        public static RPS GetPlayersChoiceOfRockPaperScissors()
        {
            Console.Write("Rock, paper, or scissors? (R/P/S): ");
            string userChoice = Console.ReadLine();
            bool validInput = false;
            do
            {
                switch (userChoice.ToLower().Trim())
                {
                    case "r":
                        return RPS.rock;
                    case "p":
                        return RPS.paper;
                    case "s":
                        return RPS.scissors;
                    default:
                        Console.WriteLine("Please enter either 'R', 'P', or 'S'.");
                        break;
                }
                return RPS.invalid;
            } while (validInput == false);
        }

    }
}
